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

    public partial class Power : Form
    {
        private static Power  frm = new Power ();
        public static Power  wind()
        {
            if (frm.IsDisposed)
            {
                frm = new Power ();
                return frm;
            }
            else
                return frm;
        }
        public Power()
        {
            InitializeComponent();
        }
    }
}
