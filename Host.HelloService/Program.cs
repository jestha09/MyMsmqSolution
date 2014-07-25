using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using HelloServiceLibrary;
using System.ServiceModel.Description;

namespace Host.HelloService
{
    class Program
    {
        static void Main(string[] args)
        {
            var binding = new NetMsmqBinding(NetMsmqSecurityMode.None);
            using (var host = new ServiceHost(typeof(HelloServiceLibrary.HelloService)))
            {
                host.AddServiceEndpoint(typeof(HelloServiceLibrary.IHelloService), binding, "net.msmq://localhost/private/MyQueue");
                host.Open();
                
                Console.ReadLine();
            }
        }
    }
}
