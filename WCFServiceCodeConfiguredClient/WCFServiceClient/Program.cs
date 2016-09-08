using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFServiceClient.Client.EmployeeServiceClient client = new WCFServiceClient.Client.EmployeeServiceClient();

            Console.WriteLine(client.GetEmployee("1").Name);

        }
    }
}
