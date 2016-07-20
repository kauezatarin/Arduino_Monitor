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
    public partial class Config_form : Form
    {
        Main InstanciaMain;//instancia o main form para acesso de metodos

        public Config_form(Main main)//recebe o endereço do main
        {
            InitializeComponent();

            InstanciaMain = main;//permite o acesso as funcções do main
        }

        private void Config_form_Load(object sender, EventArgs e)
        {
            //carrega o campo 1
            tb_Campo1.Text = Properties.Settings.Default.campo1;
            tb_Campo1_Un.Text = Properties.Settings.Default.campo1_un;
            tb_Parametro1.Text = Properties.Settings.Default.parametro1;

            //carrega o campo 2
            tb_Campo2.Text = Properties.Settings.Default.campo2;
            tb_Campo2_Un.Text = Properties.Settings.Default.campo2_un;
            tb_Parametro2.Text = Properties.Settings.Default.parametro2;

            //carrega o campo 3
            tb_Campo3.Text = Properties.Settings.Default.campo3;
            tb_Campo3_Un.Text = Properties.Settings.Default.campo3_un;
            tb_Parametro3.Text = Properties.Settings.Default.parametro3;

            //carrega o campo 4
            tb_Campo4.Text = Properties.Settings.Default.campo4;
            tb_Campo4_Un.Text = Properties.Settings.Default.campo4_un;
            tb_Parametro4.Text = Properties.Settings.Default.parametro4;

            //carrega o campo 5
            tb_Campo5.Text = Properties.Settings.Default.campo5;
            tb_Campo5_Un.Text = Properties.Settings.Default.campo5_un;
            tb_Parametro5.Text = Properties.Settings.Default.parametro5;

            //carrega o campo API Key
            tb_APIkey.Text = Properties.Settings.Default.thingspeak_API_key;

            load_Check_Configs();//carrega as configs das checkbox
        }

        /*-------Funções de chamada---------*/
        private void load_Check_Configs()//carrega as configs das checkbox
        {
            //le a configuração check box 1
            if (Properties.Settings.Default.ligado1 == true)
            {
                cb_Campo1.Checked = true;
            }

            //le a configuração check box 2
            if (Properties.Settings.Default.ligado2 == true)
            {
                cb_Campo2.Checked = true;
            }

            //le a configuração check box 3
            if (Properties.Settings.Default.ligado3 == true)
            {
                cb_Campo3.Checked = true;
            }

            //le a configuração check box 4
            if (Properties.Settings.Default.ligado4 == true)
            {
                cb_Campo4.Checked = true;
            }

            //le a configuração check box 5
            if (Properties.Settings.Default.ligado5 == true)
            {
                cb_Campo5.Checked = true;
            }

            //le a configuração check box ThingSpeak
            if (Properties.Settings.Default.ligado_thingspeak == true)
            {
                cb_ThingSpeak.Checked = true;
            }
        }

        /*-------Botões---------------------*/
        private void btn_Aplly_Click(object sender, EventArgs e)//botão de aplicar as configurações
        {            
            //salva o campo 1
            Properties.Settings.Default.campo1 = tb_Campo1.Text;
            Properties.Settings.Default.campo1_un = tb_Campo1_Un.Text;
            Properties.Settings.Default.parametro1 = tb_Parametro1.Text;
            Properties.Settings.Default.ligado1 = cb_Campo1.Checked;

            //salva o campo 2
            Properties.Settings.Default.campo2 = tb_Campo2.Text;
            Properties.Settings.Default.campo2_un = tb_Campo2_Un.Text;
            Properties.Settings.Default.parametro2 = tb_Parametro2.Text;
            Properties.Settings.Default.ligado2 = cb_Campo2.Checked;

            //salva o campo 3
            Properties.Settings.Default.campo3 = tb_Campo3.Text;
            Properties.Settings.Default.campo3_un = tb_Campo3_Un.Text;
            Properties.Settings.Default.parametro3 = tb_Parametro3.Text;
            Properties.Settings.Default.ligado3 = cb_Campo3.Checked;

            //salva o campo 4
            Properties.Settings.Default.campo4 = tb_Campo4.Text;
            Properties.Settings.Default.campo4_un = tb_Campo4_Un.Text;
            Properties.Settings.Default.parametro4 = tb_Parametro4.Text;
            Properties.Settings.Default.ligado4 = cb_Campo4.Checked;

            //salva o campo 5
            Properties.Settings.Default.campo5 = tb_Campo5.Text;
            Properties.Settings.Default.campo5_un = tb_Campo5_Un.Text;
            Properties.Settings.Default.parametro5 = tb_Parametro5.Text;
            Properties.Settings.Default.ligado5 = cb_Campo5.Checked;

            //Salva ThingSpeak congis
            Properties.Settings.Default.thingspeak_API_key = tb_APIkey.Text;
            Properties.Settings.Default.ligado_thingspeak = cb_ThingSpeak.Checked;

            //carrega as novas configs no main
            InstanciaMain.Load_labels();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)//fecha o form
        {
            this.Close();
        }
    }
}
