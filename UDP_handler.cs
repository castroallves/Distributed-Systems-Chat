// Software By: Pedro Castro Alves
// GitHub: castroallves

//NON NOBIS DOMINE, NON NOBIS, SED NOMINI TUO DA GLORIAM ♰ IN HOC SIGNO VINCES


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trabalho_SD
{
     public class UDP_handler
    {
        Thread threadRecebimentosPacotes = null;

        //MODELO 1 CONEXAO UDP:
        UdpClient usocketConexaoUDP = null;
        IAsyncResult resultado;
        byte[] bytes = new byte[1024];
        IPEndPoint ipConexaoRecebimentoUDP = null;
        IPEndPoint ipConexaoEnvioUDP = null;
        string menssagemRecebida;

        private void IniciaConexoesUDP()
        {
            usocketConexaoUDP = new UdpClient(12345);
            ipConexaoRecebimentoUDP = new IPEndPoint(IPAddress.Any, 0);
            ipConexaoEnvioUDP = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 12345);
            //resultado = usocketConexaoUDP.BeginReceive(RecebimentoPacotesUDP, new object());
            //textBoxRecepcaoConexao.Text = textBoxRecepcaoConexao.Text + "UDP CONECTADO !!!" + Environment.NewLine;

            threadRecebimentosPacotes = new Thread(RecebimentoPacotesUDP);
            threadRecebimentosPacotes.Start();
        }
        private void RecebimentoPacotesUDP()
        {
            while (true)
            {
                bytes = usocketConexaoUDP.Receive(ref ipConexaoRecebimentoUDP);
                menssagemRecebida = Encoding.ASCII.GetString(bytes);
                //textBoxRecepcaoConexao.Text = textBoxRecepcaoConexao.Text + "RECEBEU_UDP (" + ipConexaoRecebimentoUDP.Port.ToString() + ") >>" + menssagemRecebida + Environment.NewLine;
                Thread.Sleep(300);
            }

        }
        private void EnviaPacotesUDP(string menssagem)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(menssagem);
            usocketConexaoUDP.Send(bytes, bytes.Length, ipConexaoEnvioUDP);
        }
        private void FechaConexoesUDP()
        {
            usocketConexaoUDP.Close();
        }

    }
}
