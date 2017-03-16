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
    public partial class SystemConfig : Form
    {

        public SystemConfig()
        {
            InitializeComponent();
        }
        private static SystemConfig  frm = new SystemConfig ();
        public static SystemConfig  wind()
        {
            if (frm.IsDisposed)
            {
                frm = new SystemConfig ();
                return frm;
            }
            else
                return frm;
        }
    }
}
