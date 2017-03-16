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

        private void SystemConfig_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“granaryDataSet.Storage”中。您可以根据需要移动或删除它。
            this.storageTableAdapter.Fill(this.granaryDataSet.Storage);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.storageTableAdapter.Fill(this.granaryDataSet.Storage);
        }
    }
}
