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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trabalho_SD
{
    
    public partial class FormTelaPrincipal : Form
    {
        Thread threadRecebimentosPacotes = null;

        //MODELO 1 CONEXAO TCP:
        TcpClient tcpCliente;
        StreamWriter tcpStreamSaidaConexao;

        //MODELO 2 CONEXAO TCP:
        Socket socketConexaoTCP2 = null;
        byte[] bytes = new byte[1024];

        //MODELO 1 CONEXAO UDP:
        UdpClient usocketConexaoUDP = null;
        IAsyncResult resultado;
        IPEndPoint ipConexaoRecebimentoUDP = null;
        IPEndPoint ipConexaoEnvioUDP = null;
        string menssagemRecebida;
        static int conn_counter = 0;
        List<User> users = new List<User>();


        public FormTelaPrincipal()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //possibilita que componentes sejam chamados por threads diferentes                                    //PASSO 1: encontra o IP e atribui a classe principal de dados e controle 
        }





        //------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------
 
        private void FechaConexoesUDP()
        {
            usocketConexaoUDP.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void NewSession(string nick, int id)
        {
            var newForm = new FormUserChat(nick, id);
            
            users.Add(new User(id, nick));
            users[conn_counter].NewSession(nick);
            newForm.Text = "Chat " + nick;
            newForm.Show();
            newForm.label2.Text = "Olá, " + nick.ToString();
            conn_counter++;

        }

        private void bt_NewSession_Click(object sender, EventArgs e)
        {
            //var newForm = new FormUserChat();
            
            //users.Add(new User(conn_counter, tb_UserName.Text));
            //u1.NewSession(tb_UserName.Text);
            //users[conn_counter].NewSession(tb_UserName.Text);
            //newForm.Show();
            
            //newForm.label2.Text = "Bem Vindo ao chat " + tb_UserName.Text;
            conn_counter++;
            //IniciaConexoesUDP();

        }

        private void bt_Alice_Click(object sender, EventArgs e)
        {
            NewSession("Alice", 0);

        }

        private void bt_Bob_Click(object sender, EventArgs e)
        {
            NewSession("Bob", 1);
        }

        private void bt_Carol_Click(object sender, EventArgs e)
        {
            NewSession("Carol", 2);
        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }//fim classe
}
