using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempLogger
{
    public partial class Form1 : Form
    {
        private SerialPort PortaSerial = new SerialPort();

        UInt32 TempoConexa0 = 0;

        enum Identificador
        {
            WIFI_Parameters,
            Temperatura,
            StatusConexao
        };


        public Form1()
        {
            InitializeComponent();
        }

        void AtualizarPortas()
        {
            string[] NomesDasPortas = SerialPort.GetPortNames();

            cbxPorta.Items.Clear();

            cbxPorta.Text = string.Empty;

            foreach (string porta in NomesDasPortas)
            {
                cbxPorta.Items.Add(porta);
            }

            if (cbxPorta.Items.Count > 0)
            {
                cbxPorta.SelectedIndex = 0;
            }            
        }

        private void btnRefreshSerial_Click(object sender, EventArgs e)
        {
            AtualizarPortas();
        }

        void IdentificarPacote(string Pacote)
        {
            /* Pacote das constantes PID_V: Identificador.ConstantesPIDTensão, kp, ki, kd
             * Pacote das constantes PID_I: Identificador.ConstantesPIDCorrente, kp, ki, kd
             * Pacote dos parametros: Identificador.ParâmetrosSintetização, Tensão, Corrente, Index frequência, Index Fase, Index Fator de Potência
             * Pacote tensão e corrente RMS: Identificador.ID_RX_PID_Tensão, VA, VB, VC, CS
             *                               Identificador.ID_RX_PID_Corrente, IA, IB, IC, CS                                                                    S                 
             */
            string[] partes = Pacote.Split(',');

            if (partes.Length > 0)
            {
                switch (int.Parse(partes[0]))//Partes 0 contém o identificador!!
                {
                    case 0: //SSID e senha
                        txtSSID.Invoke(new Action(() =>
                        {
                            txtSSID.Text = partes[1];
                            txtSenha.Text = partes[2];
                        }));
                        break;
                    case 1: //Temperaturas 1 e 2
                        lblTemp1.Invoke(new Action(() =>
                        {
                            lblTemp1.Text = partes[1];
                            lblTemp2.Text = partes[2];
                        }));
                        break;
                    case 2: //Status da conexão
                        if (partes[1] == "1")
                        {
                            lblConexao.Invoke(new Action(() =>
                            {
                                lblConexao.Text = "Conectado";
                                TempoConexa0 = 0;
                            }));
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private ushort Crc16Ccitt(String trama)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(trama);
            const ushort poly = 4129;
            ushort[] table = new ushort[256];
            ushort initialValue = 0xffff;
            ushort temp, a;
            ushort crc = initialValue;
            for (int i = 0; i < table.Length; ++i)
            {
                temp = 0;
                a = (ushort)(i << 8);
                for (int j = 0; j < 8; ++j)
                {
                    if (((temp ^ a) & 0x8000) != 0)
                        temp = (ushort)((temp << 1) ^ poly);
                    else
                        temp <<= 1;
                    a <<= 1;
                }
                table[i] = temp;
            }
            for (int i = 0; i < bytes.Length; ++i)
            {
                crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xff & bytes[i]))]);
            }
            return crc;
        }

        private void PortaSerial_DadoRecebido(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string DadoRecebido = PortaSerial.ReadLine();
                Console.WriteLine("Dado recebido: " + DadoRecebido);
                //LOG_TXT("Dado Recebido: " + DadoRecebido);

                PortaSerial.DiscardInBuffer();

                int IndexVirgulaCS = DadoRecebido.LastIndexOf(',');
                int IndexfinalCS = DadoRecebido.LastIndexOf('\r');
                string TramaSemCS = string.Empty;
                ushort CS_rec = 0;

                if (IndexVirgulaCS != -1)
                {
                    TramaSemCS = DadoRecebido.Substring(0, IndexVirgulaCS) + ",";
                    CS_rec = ushort.Parse(DadoRecebido.Substring(IndexVirgulaCS + 1, (IndexfinalCS - IndexVirgulaCS - 1)));

                    //LOG_TXT("Trama Recebida sem CS: " + TramaSemCS);
                    //LOG_TXT("CS da Trama recebida: " + CS_rec);

                    ushort CS_calc = Crc16Ccitt(TramaSemCS);

                    if (CS_calc == CS_rec)
                    {
                        IdentificarPacote(TramaSemCS);
                    }
                    else
                    {
                        Console.WriteLine("Erro de checksum");
                    }
                }
                else
                {
                    Console.WriteLine("A trama recebida não continha ','");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnConectarSerial_Click(object sender, EventArgs e)
        {
            if (!PortaSerial.IsOpen)
            {
                if (cbxPorta.Items.Count > 0)
                {
                    try
                    {
                        PortaSerial = new SerialPort(cbxPorta.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);

                        PortaSerial.Open();

                        PortaSerial.DataReceived += new SerialDataReceivedEventHandler(PortaSerial_DadoRecebido);                        

                        //MessageBox.Show("Tudo certo com a porta serial selecionada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        
                    }
                    catch (Exception ex)                    {
                        
                        MessageBox.Show("Erro ao abrir porta serial!\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gbxWIFI.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("Selecione uma porta serial válida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (PortaSerial.IsOpen)
                {
                    btnConectarSerial.Text = "Desconectar";                   
                    cbxPorta.Enabled = false;
                    btnRefreshSerial.Enabled = false;
                    gbxWIFI.Enabled = true;
                }
            }
            else
            {
                PortaSerial.Close();
                btnConectarSerial.Text = "Conectar";
                cbxPorta.Enabled = true;
                btnRefreshSerial.Enabled = true;
                gbxWIFI.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarPortas();        
            gbxWIFI.Enabled = false;
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            string TRAMA_ENVIO = (int)Identificador.WIFI_Parameters + "," + txtSSID.Text + "," + txtSenha.Text + ",";

            if (PortaSerial.IsOpen)
            {
                String TramaComChecksum = TRAMA_ENVIO + Crc16Ccitt(TRAMA_ENVIO);
                PortaSerial.Write(TramaComChecksum + "\0");
            }
        }

        private void TimerConexao_Tick(object sender, EventArgs e)
        {
            TempoConexa0++;
            if(TempoConexa0 > 20)
            {
                lblConexao.Text = "Desconectado";
            }
        }
    }
}
