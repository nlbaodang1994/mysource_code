namespace Report_Test
{
    partial class ReportTest
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
            this.crvDemoReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnExport = new C1.Win.C1Input.C1Button();
            this.Demo_Report1 = new Report_Test.Demo_Report();
            this.SuspendLayout();
            // 
            // crvDemoReport
            // 
            this.crvDemoReport.ActiveViewIndex = -1;
            this.crvDemoReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDemoReport.DisplayGroupTree = false;
            this.crvDemoReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDemoReport.Location = new System.Drawing.Point(0, 0);
            this.crvDemoReport.Name = "crvDemoReport";
            this.crvDemoReport.SelectionFormula = "";
            this.crvDemoReport.Size = new System.Drawing.Size(917, 797);
            this.crvDemoReport.TabIndex = 1;
            this.crvDemoReport.ViewTimeSelectionFormula = "";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(384, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(88, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ReportTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 797);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.crvDemoReport);
            this.IsMdiContainer = true;
            this.Name = "ReportTest";
            this.Text = "Demo Report Test";
            this.Load += new System.EventHandler(this.ReportTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDemoReport;
        private C1.Win.C1Input.C1Button btnExport;
        private Demo_Report Demo_Report1;
    }
}

