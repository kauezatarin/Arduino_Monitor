using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // necessário para ter acesso as portas
using System.Threading;//necessário para controle de threads e delay do sistema
using System.Reflection;//necessário para pegar a versão do programa

namespace Arduino_Monitor
{
    public partial class Main : Form
    {
        string RxString;//string recebia pela serial
        string [] parametro = new string[5];//parametros a serem passados
        int RxID = 0;//controlados de dados recebidos
        Config_form Form_conf = null;//declara uma variavel para a janela de configurações
        Graphic_form Form_plotter = null;//declara uma variavel para a janela de gráficos
        Console_form Form_console = null;////declara uma variavel para a janela de console

        public Main()//não modificar
        {
            InitializeComponent();
        }

        /*-------Funções de formulario--------*/
        private void Form1_Load(object sender, EventArgs e)//ao iniciar o programa
        {
            //adiciona itens na combobox baud rate
            comboBoxBaud.Items.Add("300");
            comboBoxBaud.Items.Add("1200");
            comboBoxBaud.Items.Add("2400");
            comboBoxBaud.Items.Add("4800");
            comboBoxBaud.Items.Add("9600");
            comboBoxBaud.Items.Add("19200");
            comboBoxBaud.Items.Add("38400");
            comboBoxBaud.Items.Add("57600");
            comboBoxBaud.Items.Add("74880");
            comboBoxBaud.Items.Add("115200");
            comboBoxBaud.Items.Add("230400");
            comboBoxBaud.Items.Add("250000");

            //adiciona itens na combobox refresh
            comboBoxTime.Items.Add("2");
            comboBoxTime.Items.Add("3");
            comboBoxTime.Items.Add("4");
            comboBoxTime.Items.Add("5");
            comboBoxTime.Items.Add("10");
            comboBoxTime.Items.Add("15");
            comboBoxTime.Items.Add("20");
            comboBoxTime.Items.Add("25");
            comboBoxTime.Items.Add("30");
            comboBoxTime.Items.Add("35");
            comboBoxTime.Items.Add("40");
            comboBoxTime.Items.Add("45");
            comboBoxTime.Items.Add("50");
            comboBoxTime.Items.Add("55");
            comboBoxTime.Items.Add("60");
            comboBoxTime.Items.Add("90");
            comboBoxTime.Items.Add("120");

            Load_labels();//carrega as labels
            configurate();//le as configurações
            dicas();//inicializa as dicas

            this.Text = "Arduino Monitor  "+ ObterVersaoApp();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)//ao fechar o programa
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
                serialPort1.Close();         //fecha a porta
        }

        /*-------Funções de chamada---------*/
        private void atualizaListaCOMs()//atualiza as portas COM disponiveis
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBoxPort.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBoxPort.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBoxPort.Items.Clear();
            int counter = 0;

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBoxPort.Items.Add(s);
                counter++;
            }

            //seleciona a primeira posição da lista
            if (counter != 0)//se a lista não estiver vazia
                comboBoxPort.SelectedIndex = 0;
            else//se a lista estiver vazia
                comboBoxPort.Items.Add("");
            comboBoxPort.SelectedIndex = 0;

        }

        public void enviarComandos(string str)//envia os comandos pela serial
        {           
            if (serialPort1.IsOpen == true)//porta está aberta
            {                                              
                if (Application.OpenForms.OfType<Console_form>().Count() > 0)//se o console estiver aberto (envio manual)
                {
                    if(Form_console.tb_Send.Text != "")//se o campo enviar não estiver vazio
                    {
                        Form_console.tb_Receive.AppendText(Environment.NewLine + "Enviado: " + Form_console.tb_Send.Text);//printa no console
                        serialPort1.Write(str);  //envia o texto presente na variavel str
                    }              

                    if (Properties.Settings.Default.clear_on_send == true)//verifica a opção clear on send do console
                    {
                        Form_console.tb_Send.Text = "";
                    }
                }
                else//envio automatico
                {
                    serialPort1.Write(str);  //envia o texto presente na variavel str
                }
            }
            else
            {
                Disconnected(); //detecta que o dispositivo foi desconectado
            }
        }

        private void configurate()//le as configurações
        {            
            timerCOM.Enabled = true;//ativa o timer das portas COMS
            
            //le a configuração live scan
            if (Properties.Settings.Default.live_Scan == true)
            {
                cb_LiveScan.Checked = true;
                btScan.Enabled = false;//desativa o botão scan
            }
            else
            {
                cb_LiveScan.Checked = false;
                btScan.Enabled = true;//ativa o botão scan
            }

            //configura as combo box
            comboBoxTime.SelectedIndex = Properties.Settings.Default.refresh_index;
            comboBoxBaud.SelectedIndex = Properties.Settings.Default.baud_index;

        }

        public void Load_labels()//carrega os textos dos labels e os parametros a serem enviados pela serial
        {
            //carrega as labels caso eslas esteja ativadas
            label_Campo1.Text = Properties.Settings.Default.campo1+": ";
            label_Campo2.Text = Properties.Settings.Default.campo2+": ";
            label_Campo3.Text = Properties.Settings.Default.campo3 + ": ";
            label_Campo4.Text = Properties.Settings.Default.campo4 + ": ";
            label_Campo5.Text = Properties.Settings.Default.campo5 + ": ";

            //carrega os parametros a serem passados para o arduino
            parametro[0] = Properties.Settings.Default.parametro1;
            parametro[1] = Properties.Settings.Default.parametro2;
            parametro[2] = Properties.Settings.Default.parametro3;
            parametro[3] = Properties.Settings.Default.parametro4;
            parametro[4] = Properties.Settings.Default.parametro5;

            //desativa os displays
            if (Properties.Settings.Default.ligado1 == false)
                display_Campo1.Text = "Off";

            if (Properties.Settings.Default.ligado2 == false)
                display_Campo2.Text = "Off";

            if (Properties.Settings.Default.ligado3 == false)
                display_Campo3.Text = "Off";

            if (Properties.Settings.Default.ligado4 == false)
                display_Campo4.Text = "Off";

            if (Properties.Settings.Default.ligado5 == false)
                display_Campo5.Text = "Off";
        }

        private void dicas()//exibe as caixas de dicas
        {
            /*-----dica live scan-----*/
            System.Windows.Forms.ToolTip dicaLiveScan = new System.Windows.Forms.ToolTip();
            dicaLiveScan.SetToolTip(this.cb_LiveScan, "Busca automatica de dispositivos");

            /*-----dica Refresh Time-----*/
            System.Windows.Forms.ToolTip dicaRefresh = new System.Windows.Forms.ToolTip();
            dicaRefresh.SetToolTip(this.comboBoxTime, "Tempo entre as solicitações enviadas ao dispositivo");

            /*-----dica Opções-----*/
            System.Windows.Forms.ToolTip dicaOpcoes = new System.Windows.Forms.ToolTip();
            dicaOpcoes.SetToolTip(this.btn_Config, "Opções");

            /*-----dica Baud-----*/
            System.Windows.Forms.ToolTip dicaBaud = new System.Windows.Forms.ToolTip();
            dicaBaud.SetToolTip(this.comboBoxBaud, "Velocidade de comunicação");

            /*-----dica COM Port-----*/
            System.Windows.Forms.ToolTip dicaCOM = new System.Windows.Forms.ToolTip();
            dicaCOM.SetToolTip(this.comboBoxPort, "Selecione a porta COM em que o dispositivo está conectado");

            /*-----dica Conectar-----*/
            System.Windows.Forms.ToolTip dicaConectar = new System.Windows.Forms.ToolTip();
            dicaConectar.SetToolTip(this.btConectar, "Conectar ao dispositivo selecionado");

            /*-----dica Scan-----*/
            System.Windows.Forms.ToolTip dicaScan = new System.Windows.Forms.ToolTip();
            dicaScan.SetToolTip(this.btScan, "Procurar por dispositivos");
        }

        private void data_Manager()//gerencia os pedidos de dados e os locais de impressão
        {
            if (RxID == 0)
            {
                if (Properties.Settings.Default.ligado1 == true)
                {
                    enviarComandos(parametro[0]);//solicita o update dos dados ao arduino para o campo 1
                    RxID = 1;
                }
                else
                {
                    RxID = 1;
                    data_Manager();
                }

            }
            else if (RxID == 1)
            {
                if (Properties.Settings.Default.ligado2 == true)
                {
                    enviarComandos(parametro[1]);//solicita o update dos dados ao arduino para o campo 2
                    RxID = 2;
                }
                else
                {
                    RxID = 2;
                    data_Manager();
                }
            }
            else if (RxID == 2)
            {
                if (Properties.Settings.Default.ligado3 == true)
                {
                    enviarComandos(parametro[2]);//solicita o update dos dados ao arduino para o campo 3
                    RxID = 3;
                }
                else
                {
                    RxID = 3;
                    data_Manager();
                }
            }
            else if (RxID == 3)
            {
                if (Properties.Settings.Default.ligado4 == true)
                {
                    enviarComandos(parametro[3]);//solicita o update dos dados ao arduino para o campo 4
                    RxID = 4;
                }
                else
                {
                    RxID = 4;
                    data_Manager();
                }
            }
            else if (RxID == 4)
            {
                if (Properties.Settings.Default.ligado5 == true)
                {
                    enviarComandos(parametro[4]);//solicita o update dos dados ao arduino para o campo 5
                    RxID = 0;
                }
                else
                {
                    RxID = 0;
                }
            }
        }
        
        private void Disconnected()//se o dispositivo for desconectado
        {
            try
            {
                serialPort1.Close();

                comboBoxPort.Enabled = true;//ativa o combobox COM port
                comboBoxBaud.Enabled = true;//ativa o combobox baud rate
                comboBoxTime.Enabled = true;//ativa o combobox refresh rate

                tsm_Tools_Reboot.Enabled = false;//desativa o botão de reset do dispositivo
                tsm_Tools_Plotter.Enabled = false;//desativa o botão de reset de Plotter
                tsm_Tools_Console.Enabled = false;//desativa o botão do console

                if (Application.OpenForms.OfType<Console_form>().Count() > 0)//se o console estiver aberto
                    Form_console.Close();//fecha o console

                timerDATA.Enabled = false;//desativa o timer de refresh dos dados

                RxID = 0; //reseta a variavel de controle

                //reseta os displays
                display_Campo1.Text = "-";
                display_Campo2.Text = "-";
                display_Campo3.Text = "-";
                display_Campo4.Text = "-";
                display_Campo5.Text = "-";

                if (cb_LiveScan.Checked == false)
                    btScan.Enabled = true;//ativa o botão scan

                btConectar.Text = "Conectar";

                MessageBox.Show("Dispositivo desconectado!", "Erro", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            catch
            {
                return;
            }
        }

        private string ObterVersaoApp()//retorna a versão do programa
        {
            return string.Format("[versão {0}]", Assembly.GetExecutingAssembly().GetName().Version);
        }

        private void save_comboBox()//salva a configuração das combo boxes
        {
            Properties.Settings.Default.refresh_index = comboBoxTime.SelectedIndex;
            Properties.Settings.Default.baud_index = comboBoxBaud.SelectedIndex;

            Properties.Settings.Default.Save();//salva as configurações
        }

        /*-------Botões---------------------*/
        private void btConectar_Click(object sender, EventArgs e)//botão de conectar
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBoxPort.Items[comboBoxPort.SelectedIndex].ToString();
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Items[comboBoxBaud.SelectedIndex]);
                    serialPort1.DtrEnable = false;
                    serialPort1.Open();
                }
                catch
                {
                    return;
                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "Desconectar";//muda o texto do botão conectar
                    tsm_Tools_Reboot.Enabled = true;//ativa o botão de reset do dispositivo
                    tsm_Tools_Plotter.Enabled = true;//ativa o botão do grafico
                    tsm_Tools_Console.Enabled = true;//ativa o botão do console

                    btScan.Enabled = false;//desativa o botão scan

                    comboBoxPort.Enabled = false;//desativa o combobox COM port
                    comboBoxBaud.Enabled = false;//desativa o combobox baud rate
                    comboBoxTime.Enabled = false;//desativa o combobox refresh rate

                    timerSaver.Enabled = false;//desativa o save das combo box ja que elas não podem ser modificadas
                    save_comboBox();//garante que as ultimas configurações foram salvas
                    
                    timerDATA.Interval = Convert.ToInt32(comboBoxTime.Items[comboBoxTime.SelectedIndex]) * 1000;
                    timerDATA.Enabled = true;//ativa o timer de refresh dos dados
                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBoxPort.Enabled = true;//ativa o combobox COM port
                    comboBoxBaud.Enabled = true;//ativa o combobox baud rate
                    comboBoxTime.Enabled = true;//ativa o combobox refresh rate
                    tsm_Tools_Reboot.Enabled = false;//desativa o botão de reset do dispositivo
                    tsm_Tools_Plotter.Enabled = false;//desativa o botão de grafico
                    tsm_Tools_Console.Enabled = false;//desativa o botão do console

                    timerSaver.Enabled = true;//ativa o save das combo box

                    timerDATA.Enabled = false;//desativa o timer de refresh dos dados

                    RxID = 0; //reseta a variavel de controle

                    //reseta os displays
                    display_Campo1.Text = "-";
                    display_Campo2.Text = "-";
                    display_Campo3.Text = "-";
                    display_Campo4.Text = "-";
                    display_Campo5.Text = "-";

                    if (cb_LiveScan.Checked == false)
                        btScan.Enabled = true;//ativa o botão scan

                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void scanButton_Click(object sender, EventArgs e)//botão Scan
        {
            atualizaListaCOMs();
        }

        private void btn_Config_Click(object sender, EventArgs e)//botão de configurações
        {
            if (Application.OpenForms.OfType<Config_form>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                Form_conf = new Config_form(this);//instancia o formulario filho passando a instancia main para acesso

                //descobre a posição do form principal para centralizar o filho
                int x = this.Left + (this.Width / 2) - (Form_conf.Width / 2);
                int y = this.Top + (this.Height / 2) - (Form_conf.Height / 2);

                Form_conf.Location = new Point(x, y);//seta a posição do formulario filho
                Form_conf.Show();//exibe o formulario filho
            }
            else
            {
                Form_conf.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }
                
        /*--------checkbox------------------*/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)//live scan on/off
        {
            if (timerCOM.Enabled == true)
            {
                timerCOM.Enabled = false;
                Properties.Settings.Default.live_Scan = false;//altera a configuração na sessão
                Properties.Settings.Default.Save();//salva as configurações
                btScan.Enabled = true;//ativa o botão scan
            }
            else
            {
                timerCOM.Enabled = true;
                Properties.Settings.Default.live_Scan = true;//altera a configuração do live scan
                Properties.Settings.Default.Save();//salva as configurações
                btScan.Enabled = false;//desativa o botão scan
            }
        }

        /*--------Serial Port, receber/enviar/tratar dados---------*/
        
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)//serial port
        {
            RxString = serialPort1.ReadExisting();              //le o dado disponível na serial

           this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }

        private void trataDadoRecebido(object sender, EventArgs e)//printa o dado recebido do dispositivo no console e envia para os gráficos
        {
            if(Application.OpenForms.OfType<Console_form>().Count() > 0)//se o console estiver aberto, printa os dados recebidos nele
            {
                Form_console.tb_Receive.AppendText(Environment.NewLine + RxString);
            }
            else if (RxID == 1)
            {
                display_Campo1.Text = RxString +" "+Properties.Settings.Default.campo1_un;//se o dado for uma temperatura, atualiza o campo correspondente

                if (Application.OpenForms.OfType<Graphic_form>().Count() > 0)
                {
                    RxString = RxString.Replace(".",",");//subistitui . por , para numeros quebrados
                    Form_plotter.inserir(Convert.ToDouble(RxString), "Field1");//manda para o gráfico os dados
                }                    
            }
            else if (RxID == 2)
            {
                display_Campo2.Text = RxString +" "+ Properties.Settings.Default.campo2_un;//se o dado for uma temperatura, atualiza o campo correspondente
                if (Application.OpenForms.OfType<Graphic_form>().Count() > 0)
                {
                    RxString = RxString.Replace(".", ",");//subistitui . por , para numeros quebrados
                    Form_plotter.inserir(Convert.ToDouble(RxString), "Field2");//manda para o gráfico os dados
                }                    
            }
            else if (RxID == 3)
            {
                display_Campo3.Text = RxString + " " + Properties.Settings.Default.campo3_un;//se o dado for uma temperatura, atualiza o campo correspondente
                if (Application.OpenForms.OfType<Graphic_form>().Count() > 0)
                {
                    RxString = RxString.Replace(".", ",");//subistitui . por , para numeros quebrados
                    Form_plotter.inserir(Convert.ToDouble(RxString), "Field3");//manda para o gráfico os dados
                }                    
            }
            else if (RxID == 4)
            {
                display_Campo4.Text = RxString + " " + Properties.Settings.Default.campo4_un;//se o dado for uma temperatura, atualiza o campo correspondente
                if (Application.OpenForms.OfType<Graphic_form>().Count() > 0)
                {
                    RxString = RxString.Replace(".", ",");//subistitui . por , para numeros quebrados
                    Form_plotter.inserir(Convert.ToDouble(RxString), "Field4");//manda para o gráfico os dados
                }                    
            }
            else if (RxID == 0)
            {
                display_Campo5.Text = RxString + " " + Properties.Settings.Default.campo5_un;//se o dado for uma temperatura, atualiza o campo correspondente
                if (Application.OpenForms.OfType<Graphic_form>().Count() > 0)
                {
                    RxString = RxString.Replace(".", ",");//subistitui . por , para numeros quebrados
                    Form_plotter.inserir(Convert.ToDouble(RxString), "Field5");//manda para o gráfico os dados
                }
            }
        }

        /*--------Timers--------------*/
        private void timerSaver_Tick(object sender, EventArgs e)//a cada x milisegundos salva as configuraçõesda interface principal
        {
            save_comboBox();
        }

        private void timerCOM_Tick(object sender, EventArgs e)//a cada x milisegundos executa a função
        {
            atualizaListaCOMs();
        }

        private void timerDATA_Tick(object sender, EventArgs e)//a cada x milisegundos atualiza os dados
        {
            data_Manager();
        }
        
        /*--------Menu Strip---------*/
        private void tsm_Tools_Plotter_Click(object sender, EventArgs e)//abre o plotter
        {
            if (Application.OpenForms.OfType<Graphic_form>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                Form_plotter = new Graphic_form();//instancia o formulario filho

                //descobre a posição do form principal para centralizar o filho
                int x = this.Left + (this.Width / 2) - (Form_plotter.Width / 2);
                int y = this.Top + (this.Height / 2) - (Form_plotter.Height / 2);

                Form_plotter.Location = new Point(x, y);//seta a posição do formulario filho
                Form_plotter.Show();//exibe o formulario filho
            }
            else
            {
                Form_plotter.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void tsm_Tools_Reboot_Click(object sender, EventArgs e)//botão que reinicia o despositivo
        {
            if (MessageBox.Show("Tem certeza que deseja reiniciar o dispositivo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                serialPort1.DtrEnable = true;
                Thread.Sleep(1000);
                serialPort1.DtrEnable = false;
            }
        }

        private void tsm_Tools_Console_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Console_form>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                Form_console = new Console_form(this);//instancia o formulario filho

                //descobre a posição do form principal para centralizar o filho
                int x = this.Left + (this.Width / 2) - (Form_console.Width / 2);
                int y = this.Top + (this.Height / 2) - (Form_console.Height / 2);

                Form_console.Location = new Point(x, y);//seta a posição do formulario filho
                Form_console.Show();//exibe o formulario filho

                timerDATA.Enabled = false; //desabilita o envio automatico de comandos
            }
            else
            {
                Form_console.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }
    }
}
