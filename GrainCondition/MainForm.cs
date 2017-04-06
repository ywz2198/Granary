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
using Tes.Model;
using Tes.BLL;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
namespace GrainCondition
{
    public partial class MainForm : Form
    {

        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        int[] available_com = new int[20];
        StringBuilder temp = new StringBuilder(255);
        SerialPort sp = new SerialPort();
        string filename = System.AppDomain.CurrentDomain.BaseDirectory + "control.ini";

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemConfig.wind().Show();
            SystemConfig.wind().Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindControl.wind().Show();
            WindControl.wind().Activate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.ShowDialog();
        }



        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Video.wind().Show();
            Video.wind().Activate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Power.wind().Show();
            Power.wind().Activate();
        }
        private void add_available_com_to_combobox()//检测可用端口函数
        {
            int i, j;
            for (i = 1, j = 0; i < 21; i++)//最多支持COM1--COM20
            {
                try//使用try{}catch{}语句判断可用端口
                {
                    sp.PortName = "COM" + i.ToString();
                    sp.Open();
                    sp.Close();

                    available_com[j] = i;//顺序存入变量
                    j++;
                }
                catch
                {
                    continue;
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            add_available_com_to_combobox();
            StringBuilder baud = new StringBuilder(255);
            GetPrivateProfileString("Data", "Port", "COM" + available_com[0].ToString(), temp, 255, filename);
            GetPrivateProfileString("Data", "Baud", "9600", baud, 255, filename);

            try
            {
                if (!sp.IsOpen)
                {

                    sp.PortName = temp.ToString();
                    Console.WriteLine(sp.PortName);
                    sp.BaudRate = 9600;
                    sp.Open();
                    sp.DataReceived += s_DataReceived;

                    //MessageBox.Show("串口打开");
                }
                else
                {
                    sp.Close();
                    sp.DataReceived -= s_DataReceived;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        void s_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp.IsOpen == true)
            {
                try
                {
                    Byte[] REV = new Byte[sp.BytesToRead];
                    sp.Read(REV, 0, REV.Length);
                    sp.DiscardInBuffer();
                    richTextBox1.Text += Encoding.ASCII.GetString(REV);
                }
                catch
                {
                    MessageBox.Show("接收出错");
                }
            }
        }
    }
}

