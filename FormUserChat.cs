// Software By: Pedro Castro Alves
// GitHub: castroallves

//NON NOBIS DOMINE, NON NOBIS, SED NOMINI TUO DA GLORIAM ♰ IN HOC SIGNO VINCES


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho_SD
{
    public partial class FormUserChat : Form
    {

            //CONEXAO UDP:

        UdpClient usocketConexaoUDP = null;
        Thread threadRecebimentosPacotes = null;
        byte[] bytes = new byte[2048];
        static int n = 0;
        private int Id;
        private string Nick;
        int[] vc = new int[3] { 0, 0, 0 };

        int conn_status = 0;
        static int dfport = 1234;
        IPEndPoint ipLocal = null; 
        IPEndPoint ipHost1 = null;
        IPEndPoint ipHost2 = null;
        IPEndPoint ipBroadSend = null;
        IPEndPoint ipBroadRecv = null;
        static string vc_pattern = @"\[[0-9]{1},[0-9]{1},[0-9]{1}\]";
        static string numb_pattern = @"[0-9]";
        Regex msg_regex = new Regex(vc_pattern);
        Regex submsg_regex = new Regex(numb_pattern);


        string msg = null;

        public FormUserChat(string nick, int id)
        {
            this.Id = id;
            this.Nick = nick;
            
            InitializeComponent();
            
            this.lb_id.Text = Id.ToString();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.atribuiIps();
            Conn_Handler();
        }

        //------------------------------------------------------------------------------------------
        private void IniciaConexoesUDP(int n)
        {
            usocketConexaoUDP = new UdpClient(ipLocal);
            ipBroadRecv = new IPEndPoint(IPAddress.Any, dfport);
            ipBroadSend = new IPEndPoint(IPAddress.Parse("255.255.255.255"), dfport);
            textBoxRecepcaoConexao.Text = textBoxRecepcaoConexao.Text + "UDP CONECTADO !!!" + Environment.NewLine;

            threadRecebimentosPacotes = new Thread(RecebimentoPacotesUDP);
            threadRecebimentosPacotes.Start();
        }
        private void RecebimentoPacotesUDP()
        {
    
            while (this.conn_status == 1)
            {
                bytes = usocketConexaoUDP.Receive(ref ipBroadRecv);
                msg = Encoding.ASCII.GetString(bytes);
                if (msg_regex.IsMatch(msg))
                {
                    Match matg = msg_regex.Match(msg);
                    string vecmat = matg.Groups[0].Value;
                    MatchCollection matg2 = submsg_regex.Matches(vecmat, 0);
                    lamport_up(matg2);
                    
                }
                textBoxRecepcaoConexao.Text = textBoxRecepcaoConexao.Text + ipBroadRecv.Address.ToString() + ": " + msg + Environment.NewLine;
                Thread.Sleep(300);
            }

        }

        private string vc_string()
        {
            string vcs = '[' + this.vc[0].ToString() + ','+ this.vc[1].ToString() + ',' + this.vc[2].ToString() + ']';

            return vcs;
        }

        private void lamport_up(MatchCollection mc)
        {

            if (conn_status == 1)
            {

                for (int i = 0; i < 3; i++)
                {
                    if (int.Parse(mc[i].Value) > vc[i]) { vc[i] = int.Parse(mc[i].Value); }
                }

                this.lb_status.Text = vc_string();
            }
        }
        private void Conn_Handler(int close)
        {
            if(close == 1) {
                conn_status = 0;
                threadRecebimentosPacotes.Abort();
                FechaConexoesUDP();
            }
        }
        

            private void Conn_Handler()
        {
            if(conn_status == 0)
            {
                conn_status = 1;
                IniciaConexoesUDP(Id);
                this.EnviaPacotesUDP(Nick + " Conectado", 0);
                bt_Conn1.Enabled = true;
                bt_Conn2.Enabled = true;
                bt_Broadcast.Enabled = true;
                bt_Disconn.BackColor = Color.Red;
            }

            else if (conn_status == 1)
            {
                conn_status = 0;
                FechaConexoesUDP();
                bt_Conn1.Enabled = false;
                bt_Conn2.Enabled = false;
                bt_Broadcast.Enabled = false;
                bt_Disconn.BackColor = Color.Green;
            }
        }

        private void lamport()
        {
           
                this.vc[this.Id]++;

            if (conn_status == 1)
            {
                this.lb_status.Text = vc_string();
            }
        }
        private void EnviaPacotesUDP(string menssagem, int host)
        {
            lamport();
            
            byte[] bytes =Encoding.ASCII.GetBytes(vc_string() + " " + menssagem);

            if (host == 1)
            {
                usocketConexaoUDP.Send(bytes, bytes.Length, ipHost1);
            }
            else if(host == 2)
            {
                usocketConexaoUDP.Send(bytes, bytes.Length, ipHost2);
            }

            else if(host == 0)
            {
                usocketConexaoUDP.Send(bytes, bytes.Length, ipBroadSend);
            }

        }
        private void FechaConexoesUDP()
        {
            
            this.EnviaPacotesUDP(this.Nick + " Desconectado", 0);
            usocketConexaoUDP.Close();
       
        }

        private void atribuiIps() {
            if (this.Id == 0) //// ALICE
            {
    
                this.ipLocal = new IPEndPoint(IPAddress.Parse("127.0.0.1"), dfport);
                this.ipHost1 = new IPEndPoint(IPAddress.Parse("127.0.0.2"), dfport);
                this.ipHost2 = new IPEndPoint(IPAddress.Parse("127.0.0.3"), dfport);
            }

            else if (this.Id == 1) //// BOB
            {
                bt_Conn1.Text = "Alice";
                bt_Conn2.Text = "Carol";
                this.ipLocal = new IPEndPoint(IPAddress.Parse("127.0.0.2"), dfport);
                this.ipHost1 = new IPEndPoint(IPAddress.Parse("127.0.0.1"), dfport);
                this.ipHost2 = new IPEndPoint(IPAddress.Parse("127.0.0.3"), dfport);
            }

            else if (this.Id == 2) //// CAROL
            {
                bt_Conn1.Text = "Alice";
                bt_Conn2.Text = "Bob";
                this.ipLocal = new IPEndPoint(IPAddress.Parse("127.0.0.3"), dfport);
                this.ipHost1 = new IPEndPoint(IPAddress.Parse("127.0.0.1"), dfport);
                this.ipHost2 = new IPEndPoint(IPAddress.Parse("127.0.0.2"), dfport);
            }

            this.lb_id.Text = this.ipLocal.Address.ToString();

        }
        private void bt_connect_Click(object sender, EventArgs e)
        {
            
            IniciaConexoesUDP(n);
            n++;
            lb_status.Text = lb_status.Text + " Conectado";
        }

        private void buttonEnvioMsg_Click(object sender, EventArgs e)
        {
            EnviaPacotesUDP(textBoxEnvio.Text, 0);
           
        }

        private void bt_Conn1_Click(object sender, EventArgs e)
        {
            EnviaPacotesUDP(textBoxEnvio.Text, 1);

        }

        private void bt_Conn2_Click(object sender, EventArgs e)
        {
            EnviaPacotesUDP(textBoxEnvio.Text, 2);
        }

        private void bt_Broadcast_Click(object sender, EventArgs e)
        {
            EnviaPacotesUDP(textBoxEnvio.Text, 0);
        }

        private void lb_status_Click(object sender, EventArgs e)
        {

        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }

        private void FormUserChat_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_Disconn_Click(object sender, EventArgs e)
        {
            Conn_Handler();
        }

        private void FormUserChat_FormClosing(Object sender, FormClosingEventArgs e)
        {
            this.Conn_Handler(1);

        }

 
    }
}
