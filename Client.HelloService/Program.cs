using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using HelloServiceLibrary;
using System.ServiceModel.Channels;

namespace Client.HelloService
{
    class Program
    {
        static void Main(string[] args)
        {
            var binding = new NetMsmqBinding(NetMsmqSecurityMode.None);
            var factory = new ChannelFactory<HelloServiceLibrary.IHelloService>(binding, "net.msmq://localhost/private/MyQueue");

            var myChannel = factory.CreateChannel();

            //Uri myUri = new Uri("net.msmq://localhost/private/MyQueue");
            //var myChannel = new ServiceHost(typeof(HelloService),myUri);
            //Error; not configured properly
            try
            {
                //myChannel.Open();
                myChannel.SayHello("Jestha W");
                var IsChannelOkay = myChannel as IChannel;
                if (IsChannelOkay != null)
                    IsChannelOkay.Close();
            }
            catch (Exception)
            {
                //throw;
            }
        }
    }
}

