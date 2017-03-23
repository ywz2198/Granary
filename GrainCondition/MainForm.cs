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
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemConfig .wind().Show();
            SystemConfig .wind().Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindControl.wind().Show();
            WindControl.wind().Activate();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            History his = new History() ;
            his.ShowDialog();
        }



        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Video .wind().Show();
            Video .wind().Activate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Power .wind().Show();
            Power .wind().Activate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
