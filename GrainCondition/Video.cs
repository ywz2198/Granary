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
    public partial class Video : Form
    {
        private static Video  frm = new Video ();
        public static Video  wind()
        {
            if (frm.IsDisposed)
            {
                frm = new Video ();
                return frm;
            }
            else
                return frm;
        }
        public Video()
        {
            InitializeComponent();
        }
    }
}
