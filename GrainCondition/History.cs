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
            Series ser = chart1.Series[0];
            ser.ChartType = SeriesChartType.Spline;
            ser.BorderWidth = 2;
            ser.Color = Color.Red;
            ser.LegendText = "层"+;
        }
    }
}
