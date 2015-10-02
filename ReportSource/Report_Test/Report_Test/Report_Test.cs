using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Sql;
using System.Data.SqlClient;
using CrystalDecisions.Shared;

namespace Report_Test
{
    /// <summary>
    /// Test report 
    /// </summary>
    public partial class ReportTest : Form
    {
        ReportDocument report = new ReportDocument();

        public ReportTest()
        {
            InitializeComponent();
        }

        private DataSet Getdata()
        {
            string cnStr = @"Server=AS025\SQL2012;Database=DM81R2;User ID=sa;Password=gs123456;Trusted_Connection=False;";
            //Mở kết nối
            SqlConnection cn= new SqlConnection(cnStr);
            //
            string sql = "select top 20 * from AT9000";
            cn.Open();
            SqlDataAdapter adp = new SqlDataAdapter(sql, cn);
            DataSet ds=new DataSet();
            adp.Fill(ds, "table1");
            return ds;
        }

        #region Handler Events
        /// <summary>
        /// Sự kiện xuất Format options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = "E:\\ReportSource\\Report_Test\\Report_Test\\bin\\Export.xls";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Crystal report |(*.rpt)| Portable Document Format |(*.pdf)| MS Excel 97-2003 |(*.xls)| MS Excel 97-2003 (Data Only)|(*.xls)| MS Word |(*.doc)|";
            
            ExportOptions _exportOpts = new ExportOptions();
            DiskFileDestinationOptions _diskDesOpts = new DiskFileDestinationOptions();
            _exportOpts = report.ExportOptions;
            if (save.FileName != "")
            {
                switch (save.FilterIndex)
                {
                  
                    case 1: 
                        _exportOpts.ExportFormatType = ExportFormatType.CrystalReport;
                        break;
                    case 2:
                        _exportOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
                        Export_Opts _frmExpOpts = new Export_Opts();
                        _frmExpOpts.ShowDialog();
                        break;
                    case 3:
                        _exportOpts.ExportFormatType = ExportFormatType.Excel;
                        ExcelFormatOption _frmExFormatOpts = new ExcelFormatOption();
                        _frmExFormatOpts.ShowDialog();
                        break;
                    case 4:
                        _exportOpts.ExportFormatType = ExportFormatType.ExcelRecord;
                        _frmExFormatOpts = new ExcelFormatOption();
                        _frmExFormatOpts.ShowDialog();
                        break;
                    case 5:
                        _exportOpts.ExportFormatType = ExportFormatType.WordForWindows;
                        _frmExpOpts = new Export_Opts();
                        _frmExpOpts.ShowDialog();
                        break;
                }
            }                    
            //Ổ đĩa lưu giữ file
            _exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
            _diskDesOpts.DiskFileName = fileName;
            _exportOpts.DestinationOptions = _diskDesOpts;
        }

        /// <summary>
        /// Load form report viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportTest_Load(object sender, EventArgs e)
        {
            report.Load(Application.StartupPath + "\\Demo_Report.rpt");
            report.SetDataSource(Getdata().Tables[0]);
            crvDemoReport.ReportSource = report;
            crvDemoReport.Refresh();
        }
        #endregion-----Handler Events
    }
}
