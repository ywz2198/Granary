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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        private static History  frm = new History  ();
        public static History  wind()
        {
            if (frm.IsDisposed)
            {
                frm = new History ();
                return frm;
            }
            else
                return frm;
        }
        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
