using CrystalDecisions.Shared;
namespace Report_Test
{
    partial class ExcelFormatOption
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
            this.grpColWidth = new System.Windows.Forms.GroupBox();
            this.txtPointWidth = new C1.Win.C1Input.C1TextBox();
            this.rdbConstWid = new System.Windows.Forms.RadioButton();
            this.rdbColWidOb = new System.Windows.Forms.RadioButton();
            this.lblSepLine = new System.Windows.Forms.Label();
            this.lblPageExport = new System.Windows.Forms.Label();
            this.chkPageBreak = new System.Windows.Forms.CheckBox();
            this.chkConvDatetoString = new System.Windows.Forms.CheckBox();
            this.chkShowGridLines = new System.Windows.Forms.CheckBox();
            this.lblSepLine_2 = new System.Windows.Forms.Label();
            this.grpPageRange = new System.Windows.Forms.GroupBox();
            this.lblToPageRange = new System.Windows.Forms.Label();
            this.c1TextBox3 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.rdbFromPageRange = new System.Windows.Forms.RadioButton();
            this.rdbAllpages = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboColWidth = new System.Windows.Forms.ComboBox();
            this.cboExportPage = new System.Windows.Forms.ComboBox();
            this.grpColWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPointWidth)).BeginInit();
            this.grpPageRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpColWidth
            // 
            this.grpColWidth.Controls.Add(this.cboColWidth);
            this.grpColWidth.Controls.Add(this.txtPointWidth);
            this.grpColWidth.Controls.Add(this.rdbConstWid);
            this.grpColWidth.Controls.Add(this.rdbColWidOb);
            this.grpColWidth.Location = new System.Drawing.Point(8, 8);
            this.grpColWidth.Name = "grpColWidth";
            this.grpColWidth.Size = new System.Drawing.Size(568, 104);
            this.grpColWidth.TabIndex = 0;
            this.grpColWidth.TabStop = false;
            this.grpColWidth.Text = "Column Width";
            // 
            // txtPointWidth
            // 
            this.txtPointWidth.Location = new System.Drawing.Point(312, 56);
            this.txtPointWidth.Name = "txtPointWidth";
            this.txtPointWidth.Size = new System.Drawing.Size(96, 20);
            this.txtPointWidth.TabIndex = 2;
            this.txtPointWidth.Tag = null;
            this.txtPointWidth.TextDetached = true;
            // 
            // rdbConstWid
            // 
            this.rdbConstWid.AutoSize = true;
            this.rdbConstWid.Location = new System.Drawing.Point(16, 58);
            this.rdbConstWid.Name = "rdbConstWid";
            this.rdbConstWid.Size = new System.Drawing.Size(175, 17);
            this.rdbConstWid.TabIndex = 1;
            this.rdbConstWid.TabStop = true;
            this.rdbConstWid.Text = "Constant column width (in point)";
            this.rdbConstWid.UseVisualStyleBackColor = true;
            // 
            // rdbColWidOb
            // 
            this.rdbColWidOb.AutoSize = true;
            this.rdbColWidOb.Location = new System.Drawing.Point(16, 26);
            this.rdbColWidOb.Name = "rdbColWidOb";
            this.rdbColWidOb.Size = new System.Drawing.Size(201, 17);
            this.rdbColWidOb.TabIndex = 0;
            this.rdbColWidOb.TabStop = true;
            this.rdbColWidOb.Text = "Column width based on objects in the";
            this.rdbColWidOb.UseVisualStyleBackColor = true;
            // 
            // lblSepLine
            // 
            this.lblSepLine.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSepLine.Location = new System.Drawing.Point(8, 152);
            this.lblSepLine.Name = "lblSepLine";
            this.lblSepLine.Size = new System.Drawing.Size(568, 1);
            this.lblSepLine.TabIndex = 1;
            // 
            // lblPageExport
            // 
            this.lblPageExport.AutoSize = true;
            this.lblPageExport.Location = new System.Drawing.Point(8, 120);
            this.lblPageExport.Name = "lblPageExport";
            this.lblPageExport.Size = new System.Drawing.Size(188, 13);
            this.lblPageExport.TabIndex = 2;
            this.lblPageExport.Text = "Export page headers and page footers";
            // 
            // chkPageBreak
            // 
            this.chkPageBreak.AutoSize = true;
            this.chkPageBreak.Location = new System.Drawing.Point(16, 160);
            this.chkPageBreak.Name = "chkPageBreak";
            this.chkPageBreak.Size = new System.Drawing.Size(188, 17);
            this.chkPageBreak.TabIndex = 5;
            this.chkPageBreak.Text = "Create page breaks for each page";
            this.chkPageBreak.UseVisualStyleBackColor = true;
            // 
            // chkConvDatetoString
            // 
            this.chkConvDatetoString.AutoSize = true;
            this.chkConvDatetoString.Location = new System.Drawing.Point(16, 192);
            this.chkConvDatetoString.Name = "chkConvDatetoString";
            this.chkConvDatetoString.Size = new System.Drawing.Size(161, 17);
            this.chkConvDatetoString.TabIndex = 6;
            this.chkConvDatetoString.Text = "Convert date values to string";
            this.chkConvDatetoString.UseVisualStyleBackColor = true;
            // 
            // chkShowGridLines
            // 
            this.chkShowGridLines.AutoSize = true;
            this.chkShowGridLines.Location = new System.Drawing.Point(16, 224);
            this.chkShowGridLines.Name = "chkShowGridLines";
            this.chkShowGridLines.Size = new System.Drawing.Size(96, 17);
            this.chkShowGridLines.TabIndex = 7;
            this.chkShowGridLines.Text = "Show Gridlines";
            this.chkShowGridLines.UseVisualStyleBackColor = true;
            // 
            // lblSepLine_2
            // 
            this.lblSepLine_2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSepLine_2.Location = new System.Drawing.Point(8, 248);
            this.lblSepLine_2.Name = "lblSepLine_2";
            this.lblSepLine_2.Size = new System.Drawing.Size(568, 1);
            this.lblSepLine_2.TabIndex = 8;
            // 
            // grpPageRange
            // 
            this.grpPageRange.Controls.Add(this.lblToPageRange);
            this.grpPageRange.Controls.Add(this.c1TextBox3);
            this.grpPageRange.Controls.Add(this.c1TextBox2);
            this.grpPageRange.Controls.Add(this.rdbFromPageRange);
            this.grpPageRange.Controls.Add(this.rdbAllpages);
            this.grpPageRange.Location = new System.Drawing.Point(320, 160);
            this.grpPageRange.Name = "grpPageRange";
            this.grpPageRange.Size = new System.Drawing.Size(256, 72);
            this.grpPageRange.TabIndex = 9;
            this.grpPageRange.TabStop = false;
            this.grpPageRange.Text = "Page range";
            // 
            // lblToPageRange
            // 
            this.lblToPageRange.AutoSize = true;
            this.lblToPageRange.Location = new System.Drawing.Point(144, 52);
            this.lblToPageRange.Name = "lblToPageRange";
            this.lblToPageRange.Size = new System.Drawing.Size(26, 13);
            this.lblToPageRange.TabIndex = 10;
            this.lblToPageRange.Text = "To :";
            // 
            // c1TextBox3
            // 
            this.c1TextBox3.Location = new System.Drawing.Point(200, 48);
            this.c1TextBox3.Name = "c1TextBox3";
            this.c1TextBox3.Size = new System.Drawing.Size(40, 20);
            this.c1TextBox3.TabIndex = 6;
            this.c1TextBox3.Tag = null;
            this.c1TextBox3.TextDetached = true;
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.Location = new System.Drawing.Point(80, 48);
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.Size = new System.Drawing.Size(40, 20);
            this.c1TextBox2.TabIndex = 4;
            this.c1TextBox2.Tag = null;
            this.c1TextBox2.TextDetached = true;
            // 
            // rdbFromPageRange
            // 
            this.rdbFromPageRange.AutoSize = true;
            this.rdbFromPageRange.Location = new System.Drawing.Point(8, 48);
            this.rdbFromPageRange.Name = "rdbFromPageRange";
            this.rdbFromPageRange.Size = new System.Drawing.Size(48, 17);
            this.rdbFromPageRange.TabIndex = 5;
            this.rdbFromPageRange.TabStop = true;
            this.rdbFromPageRange.Text = "From";
            this.rdbFromPageRange.UseVisualStyleBackColor = true;
            // 
            // rdbAllpages
            // 
            this.rdbAllpages.AutoSize = true;
            this.rdbAllpages.Location = new System.Drawing.Point(8, 16);
            this.rdbAllpages.Name = "rdbAllpages";
            this.rdbAllpages.Size = new System.Drawing.Size(68, 17);
            this.rdbAllpages.TabIndex = 4;
            this.rdbAllpages.TabStop = true;
            this.rdbAllpages.Text = "All pages";
            this.rdbAllpages.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(416, 264);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(501, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboColWidth
            // 
            this.cboColWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColWidth.FormattingEnabled = true;
            this.cboColWidth.Location = new System.Drawing.Point(312, 24);
            this.cboColWidth.Name = "cboColWidth";
            this.cboColWidth.Size = new System.Drawing.Size(224, 21);
            this.cboColWidth.TabIndex = 4;
            this.cboColWidth.Items.AddRange(new object[] 
            {
                AreaSectionKind.WholeReport,
                AreaSectionKind.ReportHeader,
                AreaSectionKind.PageHeader,
                AreaSectionKind.GroupHeader,
                AreaSectionKind.Detail,
                AreaSectionKind.GroupFooter,
                AreaSectionKind.PageFooter,
                AreaSectionKind.ReportFooter
            });
            // 
            // cboExportPage
            // 
            this.cboExportPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExportPage.FormattingEnabled = true;
            this.cboExportPage.Location = new System.Drawing.Point(320, 120);
            this.cboExportPage.Name = "cboExportPage";
            this.cboExportPage.Size = new System.Drawing.Size(224, 21);
            this.cboExportPage.TabIndex = 5;
            // 
            // ExcelFormatOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 293);
            this.Controls.Add(this.cboExportPage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpPageRange);
            this.Controls.Add(this.lblSepLine_2);
            this.Controls.Add(this.chkShowGridLines);
            this.Controls.Add(this.chkConvDatetoString);
            this.Controls.Add(this.chkPageBreak);
            this.Controls.Add(this.lblPageExport);
            this.Controls.Add(this.lblSepLine);
            this.Controls.Add(this.grpColWidth);
            this.Name = "ExcelFormatOption";
            this.Text = "ExcelFormatOptions";
            this.Load += new System.EventHandler(this.ExcelFormatOption_Load);
            this.grpColWidth.ResumeLayout(false);
            this.grpColWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPointWidth)).EndInit();
            this.grpPageRange.ResumeLayout(false);
            this.grpPageRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpColWidth;
        private System.Windows.Forms.Label lblSepLine;
        private C1.Win.C1Input.C1TextBox txtPointWidth;
        private System.Windows.Forms.RadioButton rdbConstWid;
        private System.Windows.Forms.RadioButton rdbColWidOb;
        private System.Windows.Forms.Label lblPageExport;
        private System.Windows.Forms.CheckBox chkPageBreak;
        private System.Windows.Forms.CheckBox chkConvDatetoString;
        private System.Windows.Forms.CheckBox chkShowGridLines;
        private System.Windows.Forms.Label lblSepLine_2;
        private System.Windows.Forms.GroupBox grpPageRange;
        private System.Windows.Forms.Label lblToPageRange;
        private C1.Win.C1Input.C1TextBox c1TextBox3;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private System.Windows.Forms.RadioButton rdbFromPageRange;
        private System.Windows.Forms.RadioButton rdbAllpages;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboColWidth;
        private System.Windows.Forms.ComboBox cboExportPage;
    }
}