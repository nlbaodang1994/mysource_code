using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace Report_Test
{
    public class AreaOptions
    {
        public int _Index { get; set; }
        public string _Ask { get; set; }
        public AreaOptions(int stt, string Ask)
        {
            _Index = stt;
            _Ask = Ask;
        }
    }
}
