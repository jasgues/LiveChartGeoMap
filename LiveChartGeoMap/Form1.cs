using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveChartGeoMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LiveCharts.WinForms.GeoMap g = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> d = new Dictionary<string, double>();

            d["TR"] = 100;
            d["RU"] = 40;
            d["FR"] = 10;
      

            g.HeatMap = d;          
            g.Source = $"{Application.StartupPath}\\world.xml";
            g.Dock = DockStyle.Fill;
            this.Controls.Add(g);

            //event handler oluşturuyorum.
            g.LandClick += G_LandClick;

            //Zoom 
            g.EnableZoomingAndPanning = true;

            //ülke sınırlarını belirginleştirmek için
            g.LandStrokeThickness = 3;

            //Mouse Hover
            g.Hoverable = true;
        }

        private void G_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            MessageBox.Show(arg2.Name);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            


           
        }
    }
}
