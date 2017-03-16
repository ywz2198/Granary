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
    public partial class SystemForm : Form
    {
        SerialPort s = new SerialPort();
        public SystemForm()
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
        private static SystemForm frm = new SystemForm();//一个窗口
        public static SystemForm wind()
        {
            if (frm.IsDisposed)
            {
                frm = new SystemForm();
                return frm;
            }
            else
                return frm;
        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sensorDataSet.Sensor”中。您可以根据需要移动或删除它。
            this.sensorTableAdapter.Fill(this.sensorDataSet.Sensor);
            // TODO: 这行代码将数据加载到表“grainDataSet.Storage”中。您可以根据需要移动或删除它。
            this.storageTableAdapter.Fill(this.grainDataSet.Storage);
            //端口
            string[] ports = SerialPort.GetPortNames();
            comboBox2.Items.AddRange(ports);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.storageTableAdapter.Fill(this.grainDataSet.Storage);
        }
    }
}
