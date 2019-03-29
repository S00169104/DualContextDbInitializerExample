using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using WebAPIAuthenticationClient;

namespace WebAPIConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientAuthentication.baseWebAddress = "http://localhost:51132/";
            if (ClientAuthentication.login("bowles.lionie@itsligo.ie", "LBowles$1"))
            {
                Console.WriteLine("Successful login Token acquired {0} user status is {1}", ClientAuthentication.AuthToken, ClientAuthentication.AuthStatus.ToString());
            }
        }
    }
}
