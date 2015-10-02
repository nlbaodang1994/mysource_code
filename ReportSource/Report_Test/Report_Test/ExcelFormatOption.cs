using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Report_Test
{
    public partial class ExcelFormatOption : Form
    {

        public ExcelFormatOption()
        {

            InitializeComponent();
        }
        private void LoadCombo()
        {
            ExcelFormatOptions exp = new ExcelFormatOptions();
        }

        private void cboColWidOb_SelectedValueChanged(object sender, EventArgs e)
        {
            int stt = 0;
            string ask = null;
            AreaOptions _aOpts=new AreaOptions(stt,ask);
            try
            {
                AreaOptions[] list = new AreaOptions[]
            {
                new AreaOptions(1, AreaSectionKind.WholeReport.ToString()),
                new AreaOptions(2, AreaSectionKind.ReportHeader.ToString()),
                new AreaOptions(3, AreaSectionKind.PageHeader.ToString()),
                new AreaOptions(4, AreaSectionKind.GroupHeader.ToString()),
                new AreaOptions(6, AreaSectionKind.Detail.ToString()),
                new AreaOptions(7, AreaSectionKind.GroupFooter.ToString()),
                new AreaOptions(8, AreaSectionKind.PageFooter.ToString()),
                new AreaOptions(9, AreaSectionKind.ReportFooter.ToString()),
            };
                cboColWidOb.DataSource = list;
                cboColWidOb.DisplayMember = ask;
                cboColWidOb.ValueMember = ask;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void ExcelFormatOption_Load(object sender, EventArgs e)
        {

        }
      
    }
}
