using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tes.BLL;
using Tes.Model;
namespace GrainCondition
{
    public partial class History : Form
    {
        private static History frm = new History();
        public static History wind()
        {
            if (frm.IsDisposed)
            {
                frm = new History();
                return frm;
            }
            else
                return frm;
        }
        public History()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            Series ser = chart1.Series[0];
            ser.Points.Clear();
            ser.ChartType = SeriesChartType.Line;
             ser.BorderWidth = 2;
            ser.Color = Color.Red;
            ser.LegendText = "层";
            ser.XValueType = ChartValueType.Date;
          
            List<SensorInfo> data = new List<SensorInfo>(SensorBLL.GetDataByDatetime(dateTimePicker1.Value, dateTimePicker2.Value));
            
             
                foreach(SensorInfo a in data)
                {
                  ser.Points.AddXY(Convert .ToDateTime(a.Time), a.Data);
                }
            



            
        }

        private void History_Load(object sender, EventArgs e)
        {
            chart1.GetToolTipText += new EventHandler<ToolTipEventArgs>(chart1_GetToolTipText);
        }
        void chart1_GetToolTipText(object sender,ToolTipEventArgs e)
        {
            if(e.HitTestResult .ChartElementType == ChartElementType.DataPoint)
            {
                int i = e.HitTestResult.PointIndex;
                DataPoint dp = e.HitTestResult.Series.Points[i];
                e.Text = string.Format("温度：{0}", dp.YValues[0]);
            }
        }
    }
}
