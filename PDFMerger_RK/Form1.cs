#region PDFsharp - A .NET library for processing PDF
//
// Copyright (c) 2005-2012 empira Software GmbH, Troisdorf (Germany)
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFMerger_RK
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Manages information of the input files.
        /// </summary>
        private class InputItem
        {
            private PdfDocument inputDocument;
            private bool isPartialDocument = false;
            private int startPage = 0;
            private int endPage = 0;
            private string fileName;
            private bool isReadyForMerge = false;

            public InputItem(string fileName)
            {
                this.fileName = fileName;
            }

            public PdfDocument InputDocument
            {
                set { inputDocument = value; }
                get { return inputDocument; }
            }

            public bool IsPartialDocument
            {
                set { isPartialDocument = value; }
                get { return isPartialDocument; }
            }

            public int StartPage
            {
                set { startPage = value; }
                get { return startPage; }
            }

            public int EndPage
            {
                set { endPage = value; }
                get { return endPage; }
            }

            public string FileName
            {
                set { fileName = value; }
                get { return fileName; }
            }

            public bool IsReadyForMerge
            {
                set { isReadyForMerge = value; }
                get { return isReadyForMerge; }
            }
        }

        //List of input files.
        private List<InputItem> inputItems = new List<InputItem>();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF files|*.pdf;";
                ofd.Multiselect = false;
                
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    inputItems.Add(new InputItem(ofd.FileName));
                                        
                    listBoxFileName.Items.Add(ofd.FileName);
                }

                enableMergeIfReady();                
            }
            catch (FileLoadException)
            {
                MessageBox.Show("The file could not be loaded.", "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxFileName.SelectedIndex >= 0 && listBoxFileName.SelectedIndex < listBoxFileName.Items.Count)
            {
                inputItems.RemoveAt(listBoxFileName.SelectedIndex);
                listBoxFileName.Items.RemoveAt(listBoxFileName.SelectedIndex);
            }

            enableMergeIfReady();
        }

        /// <summary>
        /// Converts one or several xml files to pdf files.
        /// This method should be called when buttonConvert is clicked.
        /// </summary>
        private void merge()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF | *.pdf";
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PdfDocument outputDocument = new PdfDocument();
                for (int i = 0; i < listBoxFileName.Items.Count; i++)
                {
                    inputItems[i].InputDocument = PdfReader.Open(inputItems[i].FileName, PdfDocumentOpenMode.Import);
                    int startIdx, endIdx;
                    if (inputItems[i].IsPartialDocument == true)
                    {
                        startIdx = inputItems[i].StartPage-1;
                        endIdx = inputItems[i].EndPage;
                    }
                    else
                    {
                        startIdx = 0;
                        endIdx = inputItems[i].InputDocument.PageCount;
                    }
                    for (int j = startIdx; j < endIdx; j++)
                    {
                        outputDocument.AddPage(inputItems[i].InputDocument.Pages[j]);
                    }
                    inputItems[i].InputDocument.Dispose();
                }

                outputDocument.Save(sfd.FileName);
                Process.Start(sfd.FileName);
            }
           
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            buttonMerge.Enabled = false;
            merge();   

            buttonMerge.Enabled = true;
        }

        private void radioButtonSetPage_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSetPage.Checked == true)
            {
                textBoxStartPage.Visible = true;
                textBoxEndPage.Visible = true;
                label3.Visible = true;
                label2.Visible = true;
            }
            else
            {
                textBoxStartPage.Visible = false;
                textBoxEndPage.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
            }
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            int start, end;   
            bool startOk, endOk;
            startOk = int.TryParse(textBoxStartPage.Text, out start);
            endOk = int.TryParse(textBoxEndPage.Text, out end);

            if (radioButtonSetPage.Checked == true)
            {
                if (startOk == false || endOk == false)
                {
                    MessageBox.Show("The input value is invalid", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputItems[listBoxFileName.SelectedIndex].IsReadyForMerge = false;
                    enableMergeIfReady();
                    return;
                }

                inputItems[listBoxFileName.SelectedIndex].InputDocument = PdfReader.Open(inputItems[listBoxFileName.SelectedIndex].FileName, PdfDocumentOpenMode.Import);
                    
                if (start <= 0 || start > inputItems[listBoxFileName.SelectedIndex].InputDocument.PageCount ||
                    end < start || end > inputItems[listBoxFileName.SelectedIndex].InputDocument.PageCount)
                {
                    MessageBox.Show("Invalid page number", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputItems[listBoxFileName.SelectedIndex].IsReadyForMerge = false;
                    enableMergeIfReady();
                    return;
                }

                inputItems[listBoxFileName.SelectedIndex].InputDocument.Dispose();
            }

            inputItems[listBoxFileName.SelectedIndex].IsPartialDocument = !radioButtonWholeFile.Checked;
            inputItems[listBoxFileName.SelectedIndex].StartPage = start;
            inputItems[listBoxFileName.SelectedIndex].EndPage = end;
            inputItems[listBoxFileName.SelectedIndex].IsReadyForMerge = true;

            enableMergeIfReady();
        }

        private void listBoxFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSet.Enabled = true;
            textBoxStartPage.Text = inputItems[listBoxFileName.SelectedIndex].StartPage.ToString();
            textBoxEndPage.Text = inputItems[listBoxFileName.SelectedIndex].EndPage.ToString();
        }

        /// <summary>
        /// Enables buttonMerge if all input files are set and ready for merge, disables otherwise.
        /// </summary>
        private void enableMergeIfReady()
        {
            bool enableMerge = true;
            
            for (int i = 0; i < inputItems.Count; i++)
            {
                if (inputItems[i].IsReadyForMerge == false)
                {
                    enableMerge = false;
                }
            }

            if (inputItems.Count == 0)
            {
                enableMerge = false;
            }

            if (enableMerge == true)
            {
                buttonMerge.Enabled = true;
            }
            else
            {
                buttonMerge.Enabled = false;
            }
        }
    }
}
