using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrainCondition
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemConfig sys = new SystemConfig();
            sys.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindControl wind = new WindControl();
            bool win = wind.Enabled;
            if (!win )
            wind.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            History his = new History() ;
            if(his!=null)
            his.Show();
        }
    }
}
