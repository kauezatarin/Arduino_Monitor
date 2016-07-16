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
    public partial class Console_form : Form
    {
        Main InstanciaMain;//declara uma variavel para o main

        public Console_form(Main main)
        {
            InitializeComponent();

            InstanciaMain = main; //guarda a instancia recebida
        }

        /*------funções de formulario-----*/
        private void Console_form_Load(object sender, EventArgs e)
        {
            configurate();//le as configurações do formulario
        }
        
        private void Console_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(InstanciaMain.serialPort1.IsOpen == true)
            {
                InstanciaMain.timerDATA.Enabled = true;//ativa o envio automatico de comandos se a porta serial estiver aberta
            }            
        }

        /*---------Funções de Chamada------*/

        public void configurate()
        {
            //le a configuração clear on sent
            if (Properties.Settings.Default.clear_on_send == true)
            {
                cb_CleanOnSend.Checked = true;
                Properties.Settings.Default.clear_on_send = true;
                Properties.Settings.Default.Save();//para garantir o carregamento correto da opção
            }
            else
            {
                cb_CleanOnSend.Checked = false;
            }
        }

        /*---------Botões----------*/
        private void bt_Send_Click(object sender, EventArgs e)//envia comandos
        {
            InstanciaMain.enviarComandos(tb_Send.Text);//envia comandos
        }

        private void bt_Clear_Click(object sender, EventArgs e)//limpa a textbox receive
        {
            tb_Receive.Text = "";
        }

        /*---------Text Box---------*/
        private void tb_Send_KeyPress(object sender, KeyPressEventArgs e)//envia comandos ao precionar ENTER
        {
            if (e.KeyChar == 13)//se precionado enter
            {
                e.Handled = true;//retira o barulho chato ao precionar enter
                InstanciaMain.enviarComandos(tb_Send.Text);//envia comandos
            }
        }

        /*---------Check Box--------*/
        private void cb_CleanOnSend_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.clear_on_send == true)
            {
                Properties.Settings.Default.clear_on_send = false;//altera a configuração do clear on send
                Properties.Settings.Default.Save();//salva as configurações
            }
            else
            {
                Properties.Settings.Default.clear_on_send = true;//altera a configuração do clear on send
                Properties.Settings.Default.Save();//salva as configurações
            }
        }
    }
}
