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
    public partial class WindControl : Form
    {
        
        public  WindControl()
        {
            InitializeComponent();
        }
        private static WindControl frm = new WindControl();
        public static WindControl wind()
        {
            if (frm.IsDisposed)
            {
                frm = new WindControl();
                return frm;
            }
            else
                return frm;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
