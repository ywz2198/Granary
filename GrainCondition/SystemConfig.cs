using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml;


namespace GrainCondition
{
    public partial class SystemConfig : Form
    {
        private static SystemConfig frm = new SystemConfig();//一个窗口
        public static SystemConfig wind()
        {
            if (frm.IsDisposed)
            {
                frm = new SystemConfig();
                return frm;
            }
            else
                return frm;
        }
        public SystemConfig()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            int[] item = { 9600, 115200 };
            foreach (int a in item)
            {
                bode.Items.Add(a.ToString());
            }
            bode.SelectedItem = bode.Items[0];
        }

        private void SystemConfig_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“granaryDataSet1.Sensor”中。您可以根据需要移动或删除它。
            this.sensorTableAdapter.Fill(this.granaryDataSet1.Sensor);
            // TODO: 这行代码将数据加载到表“granaryDataSet.Storage”中。您可以根据需要移动或删除它。
            this.storageTableAdapter.Fill(this.granaryDataSet.Storage);

        }
    }
}
