using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloServiceLibrary
{
    public class HelloService : IHelloService
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
