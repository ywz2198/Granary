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
            // TODO: 这行代码将数据加载到表“granaryDataSet2.History”中。您可以根据需要移动或删除它。
            this.historyTableAdapter.Fill(this.granaryDataSet2.History);

        }
    }
}
