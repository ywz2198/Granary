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
        SerialPort sp;
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
            sp = new SerialPort();
            //准备串口内容
            Control.CheckForIllegalCrossThreadCalls = false;
            int[] item = { 9600, 115200 };
            foreach (int a in item)
            {
                bode.Items.Add(a.ToString());
            }
            bode.SelectedItem = bode.Items[0];
           foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                COM.Items.Add(s);
                COM.SelectedIndex = 0;
            }
            cbDataBits.SelectedIndex = 3;
            cbStop.SelectedIndex = 0;
            cbParity.SelectedIndex = 0;
            radio1.Checked = true;
            rbRcvStr.Checked = true;
            //串口接收
      
        }
        sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
        void sp_DataReceived(object sender, SerialDataReceivedEventHandler e)
        {
            if (sp.IsOpen)
            {
                byte[] byteRead = new byte[sp.BytesToRead];
                if (rdSendStr.Checked )
                {
                    textReceived.Text += sp.ReadLine() + "\r\n";
                    sp.DiscardInBuffer();
                }
                else
                {
                    try
                    {
                        Byte[] receivedData = new Byte[sp.BytesToRead];
                        sp.Read(receivedData, 0, receivedData.Length);
                        sp.DiscardInBuffer();
                        string strRcv = null;
                        for (int i=0;i<receivedData .Length , i++)
                        {
                            strRcv += receivedData[i].ToString("X2");

                        }
                        textReceived.Text += strRcv + "\r\n";
                    }
                    catch (System .Exception ex)
                    {
                        MessageBox.Show(ex.Message, "出错");
                        textReceived.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("请打开串口");
            }
        }

        private void SystemConfig_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“granaryDataSet1.Sensor”中。您可以根据需要移动或删除它。
            this.sensorTableAdapter.Fill(this.granaryDataSet1.Sensor);
            // TODO: 这行代码将数据加载到表“granaryDataSet.Storage”中。您可以根据需要移动或删除它。
            this.storageTableAdapter.Fill(this.granaryDataSet.Storage);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
           
            sp.Open();
            if (sp.IsOpen)
                MessageBox.Show("串口启动");
        }
    }
}
