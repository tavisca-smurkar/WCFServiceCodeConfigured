using System;
using System.ServiceModel;
using System.ServiceModel.Description;

using WCFService;

namespace EmployeeServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(EmployeeService)))
            {
                ServiceMetadataBehavior serviceBehaviour = new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true
                };
               
                host.Description.Behaviors.Add(serviceBehaviour);
                host.AddServiceEndpoint(typeof(IEmployeeService), new BasicHttpBinding(), "EmployeeService");
                host.Open();
                Console.WriteLine("Service is started at {0}", DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
