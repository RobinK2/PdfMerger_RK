namespace PDFMerger_RK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.groupBoxMulti = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.radioButtonWholeFile = new System.Windows.Forms.RadioButton();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.listBoxFileName = new System.Windows.Forms.ListBox();
            this.radioButtonSetPage = new System.Windows.Forms.RadioButton();
            this.textBoxStartPage = new System.Windows.Forms.TextBox();
            this.textBoxEndPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.groupBoxMulti.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Copyright © 2016 Robin Kase";
            // 
            // buttonMerge
            // 
            this.buttonMerge.Enabled = false;
            this.buttonMerge.Location = new System.Drawing.Point(115, 201);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(128, 42);
            this.buttonMerge.TabIndex = 13;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // groupBoxMulti
            // 
            this.groupBoxMulti.Controls.Add(this.buttonRemove);
            this.groupBoxMulti.Controls.Add(this.radioButtonWholeFile);
            this.groupBoxMulti.Controls.Add(this.buttonOpen);
            this.groupBoxMulti.Controls.Add(this.listBoxFileName);
            this.groupBoxMulti.Controls.Add(this.radioButtonSetPage);
            this.groupBoxMulti.Location = new System.Drawing.Point(53, 12);
            this.groupBoxMulti.Name = "groupBoxMulti";
            this.groupBoxMulti.Size = new System.Drawing.Size(278, 166);
            this.groupBoxMulti.TabIndex = 17;
            this.groupBoxMulti.TabStop = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(7, 66);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(61, 29);
            this.buttonRemove.TabIndex = 20;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // radioButtonWholeFile
            // 
            this.radioButtonWholeFile.AutoSize = true;
            this.radioButtonWholeFile.Checked = true;
            this.radioButtonWholeFile.Location = new System.Drawing.Point(19, 117);
            this.radioButtonWholeFile.Name = "radioButtonWholeFile";
            this.radioButtonWholeFile.Size = new System.Drawing.Size(73, 16);
            this.radioButtonWholeFile.TabIndex = 17;
            this.radioButtonWholeFile.TabStop = true;
            this.radioButtonWholeFile.Text = "Whole file";
            this.radioButtonWholeFile.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(19, 22);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(49, 29);
            this.buttonOpen.TabIndex = 14;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // listBoxFileName
            // 
            this.listBoxFileName.FormattingEnabled = true;
            this.listBoxFileName.ItemHeight = 12;
            this.listBoxFileName.Location = new System.Drawing.Point(74, 12);
            this.listBoxFileName.Name = "listBoxFileName";
            this.listBoxFileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxFileName.Size = new System.Drawing.Size(198, 100);
            this.listBoxFileName.TabIndex = 15;
            this.listBoxFileName.SelectedIndexChanged += new System.EventHandler(this.listBoxFileName_SelectedIndexChanged);
            // 
            // radioButtonSetPage
            // 
            this.radioButtonSetPage.AutoSize = true;
            this.radioButtonSetPage.Location = new System.Drawing.Point(19, 139);
            this.radioButtonSetPage.Name = "radioButtonSetPage";
            this.radioButtonSetPage.Size = new System.Drawing.Size(150, 16);
            this.radioButtonSetPage.TabIndex = 16;
            this.radioButtonSetPage.Text = "Set Page Specific Range";
            this.radioButtonSetPage.UseVisualStyleBackColor = true;
            this.radioButtonSetPage.CheckedChanged += new System.EventHandler(this.radioButtonSetPage_CheckedChanged);
            // 
            // textBoxStartPage
            // 
            this.textBoxStartPage.Location = new System.Drawing.Point(354, 150);
            this.textBoxStartPage.Name = "textBoxStartPage";
            this.textBoxStartPage.Size = new System.Drawing.Size(30, 19);
            this.textBoxStartPage.TabIndex = 18;
            this.textBoxStartPage.Visible = false;
            // 
            // textBoxEndPage
            // 
            this.textBoxEndPage.Location = new System.Drawing.Point(399, 151);
            this.textBoxEndPage.Name = "textBoxEndPage";
            this.textBoxEndPage.Size = new System.Drawing.Size(30, 19);
            this.textBoxEndPage.TabIndex = 19;
            this.textBoxEndPage.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "To Page";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "From Page";
            this.label3.Visible = false;
            // 
            // buttonSet
            // 
            this.buttonSet.Enabled = false;
            this.buttonSet.Location = new System.Drawing.Point(354, 176);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 22;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 278);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEndPage);
            this.Controls.Add(this.textBoxStartPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.groupBoxMulti);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PDFMerger RK 1.0";
            this.groupBoxMulti.ResumeLayout(false);
            this.groupBoxMulti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.GroupBox groupBoxMulti;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.RadioButton radioButtonWholeFile;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ListBox listBoxFileName;
        private System.Windows.Forms.RadioButton radioButtonSetPage;
        private System.Windows.Forms.TextBox textBoxStartPage;
        private System.Windows.Forms.TextBox textBoxEndPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSet;
    }
}