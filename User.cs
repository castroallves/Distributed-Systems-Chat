// Software By: Pedro Castro Alves
// GitHub: castroallves

//NON NOBIS DOMINE, NON NOBIS, SED NOMINI TUO DA GLORIAM ♰ IN HOC SIGNO VINCES


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabalho_SD 
{
    internal class User 
    {
        private static  List<UDP_handler> udp_connection = new List<UDP_handler>();
        static int usercount = 0;
        int id;
        string nick;

        public User(int id,string nick)
        {
            this.id = id;
            this.nick = nick;
        }

        public int NewSession(string tbnick)

        {
            usercount++;
            return usercount;
            udp_connection.Add(new UDP_handler());
            
        }


    }
}
