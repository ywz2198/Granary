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
using Tes.Model;
using Tes.BLL;
using System.Runtime.InteropServices;
namespace GrainCondition
{
    public partial class SystemConfig : Form
    {

        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
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
        StringBuilder temp = new StringBuilder(255);
        StringBuilder baud = new StringBuilder(255);
        StorageInfo si;
        public SystemConfig()
        {
            
            GetPrivateProfileString("Data", "Port", "COM1", temp, 255, filename);
            GetPrivateProfileString("Data", "Baud", "9600", baud, 255, filename);
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            int[] item = { 9600, 115200 };
            foreach (int a in item)
            {
                bode.Items.Add(a.ToString());
            }
            bode.Text = baud.ToString();
            
        }
       
       
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SerialPort sp = new SerialPort();
        string filename = System.AppDomain.CurrentDomain.BaseDirectory + "control.ini";
        private void btnSwitch_Click(object sender, EventArgs e)
        {

            if (!sp.IsOpen)
            { 
            sp.PortName = COM.Text;
            sp.BaudRate = Convert.ToInt32(bode.Text);
            sp.Open();
                btnSwitch.Text = "Close";
            }
            else
            {
                sp.Close();
                btnSwitch.Text = "Open";
            }

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (WritePrivateProfileString("Data", "Port", COM.Text, filename)&WritePrivateProfileString ("Data","Baud",bode.Text,filename))
                MessageBox.Show("ok");


        }

       

        private void SystemConfig_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            COM.Items.AddRange(ports);
            COM.Text = temp.ToString();
        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {
            si = new StorageInfo()
            {
                GrainID = Convert.ToInt32(NO.Text),
                KindOfGrain = Kind.Text,
                Keeper = Keeper.Text,
                Storage = Intime.Value.ToShortDateString(),
                Out = Outtime.Value.ToShortDateString(),
                Weight = Convert.ToInt32(Weight.Text),
                Water = float.Parse(Water.Text),
                Dirt = float.Parse(Dirt.Text),
                Incomplete = float.Parse(Incomplete.Text),
                Property = Property.Text,
                Level = Level.Text,
                Info = OtherInfo.Text,
                GrowingPlace = Place.Text,
                Other = Other.Text
            };
            string messageStr = "";
            if (StorageBLL.AddStorage(si))
            {
                MessageBox.Show("yes");
            }
            else
            {
                MessageBox.Show(messageStr);

            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            si = new StorageInfo()
            {
                GrainID = Convert.ToInt32(NO.Text),
                KindOfGrain = Kind.Text,
                Keeper = Keeper.Text,
                Storage = Intime.Value.ToShortDateString(),
                Out = Outtime.Value.ToShortDateString(),
                Weight = Convert.ToInt32(Weight.Text),
                Water = float.Parse(Water.Text),
                Dirt = float.Parse(Dirt.Text),
                Incomplete = float.Parse(Incomplete.Text),
                Property = Property.Text,
                Level = Level.Text,
                Info = OtherInfo.Text,
                GrowingPlace = Place.Text,
                Other = Other.Text


            };
            if (StorageBLL.UpdateStorageInfo(si))
                MessageBox.Show("OK");
        }

        private void ReadWithNO_Click(object sender, EventArgs e)
        {
           
            StorageInfo ss = StorageBLL.GetStorageInfoById(Convert.ToInt32(NO.Text));
            Kind.Text = ss.KindOfGrain;
            Keeper.Text = ss.Keeper;
            Weight.Text = ss.Weight.ToString();
            Water.Text = ss.Water.ToString();
            Dirt.Text = ss.Dirt.ToString();
            Incomplete.Text = ss.Incomplete.ToString();
            Property.Text = ss.Property;
            Level.Text = ss.Level;
            OtherInfo.Text = ss.Info;
            Place.Text = ss.GrowingPlace;
            Other.Text = ss.Other;
            Intime.Value = Convert.ToDateTime(ss.Storage);
            Outtime.Value = Convert.ToDateTime(ss.Out);
        }

        
    }
}

