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

namespace Arduino_Monitor
{
    public partial class Graphic_form : Form
    {
        bool registro = false;
        double rt = 0;

        public Graphic_form()
        {
            InitializeComponent();
        }

        /*-----Funções de chamada----*/
        public void inserir(double data, String field)
        {
            if (registro == false)
            {
                rt = 0;
                registro = true;
            }
             
            this.chart1.Series[field].Points.AddXY(rt, data);
        }

    }
}
