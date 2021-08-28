using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class report : Form
    {
        public report(string pReport)
        {
            InitializeComponent();
            lblReport.Text = pReport;
        }
    }
}
