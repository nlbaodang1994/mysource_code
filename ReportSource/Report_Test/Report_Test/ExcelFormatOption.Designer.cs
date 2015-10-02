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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelFormatOption));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboColWidOb = new C1.Win.C1List.C1Combo();
            this.txtPointWidth = new C1.Win.C1Input.C1TextBox();
            this.rdbConstWid = new System.Windows.Forms.RadioButton();
            this.rdbColWidOb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPageExport = new System.Windows.Forms.Label();
            this.cboExpPage = new C1.Win.C1List.C1Combo();
            this.chkPageBreak = new System.Windows.Forms.CheckBox();
            this.chkConvDatetoString = new System.Windows.Forms.CheckBox();
            this.chkShowGridLines = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c1TextBox3 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboColWidOb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPointWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExpPage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboColWidOb);
            this.groupBox1.Controls.Add(this.txtPointWidth);
            this.groupBox1.Controls.Add(this.rdbConstWid);
            this.groupBox1.Controls.Add(this.rdbColWidOb);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Column Width";
            // 
            // cboColWidOb
            // 
            this.cboColWidOb.AddItemSeparator = ';';
            this.cboColWidOb.Caption = "";
            this.cboColWidOb.CaptionHeight = 17;
            this.cboColWidOb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboColWidOb.ColumnCaptionHeight = 17;
            this.cboColWidOb.ColumnFooterHeight = 17;
            this.cboColWidOb.ContentHeight = 15;
            this.cboColWidOb.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cboColWidOb.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cboColWidOb.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColWidOb.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cboColWidOb.EditorHeight = 15;
            this.cboColWidOb.Images.Add(((System.Drawing.Image)(resources.GetObject("cboColWidOb.Images"))));
            this.cboColWidOb.ItemHeight = 15;
            this.cboColWidOb.Location = new System.Drawing.Point(312, 24);
            this.cboColWidOb.MatchEntryTimeout = ((long)(2000));
            this.cboColWidOb.MaxDropDownItems = ((short)(5));
            this.cboColWidOb.MaxLength = 32767;
            this.cboColWidOb.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cboColWidOb.Name = "cboColWidOb";
            this.cboColWidOb.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cboColWidOb.Size = new System.Drawing.Size(240, 21);
            this.cboColWidOb.TabIndex = 3;
            this.cboColWidOb.SelectedValueChanged += new System.EventHandler(this.cboColWidOb_SelectedValueChanged);
            this.cboColWidOb.PropBag = resources.GetString("cboColWidOb.PropBag");
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 1);
            this.label1.TabIndex = 1;
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
            // cboExpPage
            // 
            this.cboExpPage.AddItemSeparator = ';';
            this.cboExpPage.Caption = "";
            this.cboExpPage.CaptionHeight = 17;
            this.cboExpPage.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboExpPage.ColumnCaptionHeight = 17;
            this.cboExpPage.ColumnFooterHeight = 17;
            this.cboExpPage.ContentHeight = 15;
            this.cboExpPage.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cboExpPage.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cboExpPage.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExpPage.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cboExpPage.EditorHeight = 15;
            this.cboExpPage.Images.Add(((System.Drawing.Image)(resources.GetObject("cboExpPage.Images"))));
            this.cboExpPage.ItemHeight = 15;
            this.cboExpPage.Location = new System.Drawing.Point(320, 120);
            this.cboExpPage.MatchEntryTimeout = ((long)(2000));
            this.cboExpPage.MaxDropDownItems = ((short)(5));
            this.cboExpPage.MaxLength = 32767;
            this.cboExpPage.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cboExpPage.Name = "cboExpPage";
            this.cboExpPage.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cboExpPage.Size = new System.Drawing.Size(200, 21);
            this.cboExpPage.TabIndex = 4;
            this.cboExpPage.PropBag = resources.GetString("cboExpPage.PropBag");
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(8, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 1);
            this.label2.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.c1TextBox3);
            this.groupBox2.Controls.Add(this.c1TextBox2);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(320, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 72);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Page range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "To :";
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
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(8, 48);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "From";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All pages";
            this.radioButton3.UseVisualStyleBackColor = true;
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
            // ExcelFormatOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 293);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkShowGridLines);
            this.Controls.Add(this.chkConvDatetoString);
            this.Controls.Add(this.chkPageBreak);
            this.Controls.Add(this.cboExpPage);
            this.Controls.Add(this.lblPageExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExcelFormatOption";
            this.Text = "ExcelFormatOptions";
            this.Load += new System.EventHandler(this.ExcelFormatOption_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboColWidOb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPointWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExpPage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1List.C1Combo cboColWidOb;
        private C1.Win.C1Input.C1TextBox txtPointWidth;
        private System.Windows.Forms.RadioButton rdbConstWid;
        private System.Windows.Forms.RadioButton rdbColWidOb;
        private System.Windows.Forms.Label lblPageExport;
        private C1.Win.C1List.C1Combo cboExpPage;
        private System.Windows.Forms.CheckBox chkPageBreak;
        private System.Windows.Forms.CheckBox chkConvDatetoString;
        private System.Windows.Forms.CheckBox chkShowGridLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1Input.C1TextBox c1TextBox3;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}