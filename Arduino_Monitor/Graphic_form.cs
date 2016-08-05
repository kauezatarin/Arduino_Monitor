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

        private void Graphic_form_Load(object sender, EventArgs e)
        {
            config_Load();//carrega as configurações ao iniciar
        }

        /*-----Funções de chamada----*/
        public void config_Load()//carrega o nome dos campos
        {
            //carrega os titulos dos graficos
            this.chart1.Titles[0].Text = Properties.Settings.Default.campo1;
            this.chart1.Titles[1].Text = Properties.Settings.Default.campo2;
            this.chart1.Titles[2].Text = Properties.Settings.Default.campo3;
            this.chart1.Titles[3].Text = Properties.Settings.Default.campo4;
            this.chart1.Titles[4].Text = Properties.Settings.Default.campo5;

            //carrega as legendas
            this.chart1.Series[0].LegendText = Properties.Settings.Default.campo1;
            this.chart1.Series[1].LegendText = Properties.Settings.Default.campo2;
            this.chart1.Series[2].LegendText = Properties.Settings.Default.campo3;
            this.chart1.Series[3].LegendText = Properties.Settings.Default.campo4;
            this.chart1.Series[4].LegendText = Properties.Settings.Default.campo5;
        }
        
        public void inserir(double data, String field)//Insere os pontos nos gráficos
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
