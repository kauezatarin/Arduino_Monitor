using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Monitor
{
    public partial class Graphic_form : Form
    {
        public Graphic_form()
        {
            InitializeComponent();
        }

        bool registro = false;
        double rt = 0;

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
