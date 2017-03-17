﻿using System;
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
            // TODO: 这行代码将数据加载到表“granaryDataSet3.AlarmHistory”中。您可以根据需要移动或删除它。
            this.alarmHistoryTableAdapter.Fill(this.granaryDataSet3.AlarmHistory);
            // TODO: 这行代码将数据加载到表“granaryDataSet2.History”中。您可以根据需要移动或删除它。
            this.historyTableAdapter.Fill(this.granaryDataSet2.History);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.historyTableAdapter.FillBy(this.granaryDataSet2.History);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
