using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace getIp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHostName = string.Empty;
            strHostName = Dns.GetHostName();  // get thehost name
            Console.WriteLine("Local host name is " + strHostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);  // using host name, the ip address is obtained
            IPAddress[] addr = ipEntry.AddressList;

            Console.WriteLine("Hostname: " + strHostName);
            for (int i = 1; i < addr.Length; i++)
                Console.WriteLine("IP Address {0}: ", addr[i].ToString());
            Console.ReadKey();

        }
    }
}
