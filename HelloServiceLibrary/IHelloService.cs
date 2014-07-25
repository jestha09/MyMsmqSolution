using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HelloServiceLibrary
{
    [ServiceContract]
    public interface IHelloService
    {
        //[OperationContract]
        [OperationContract(IsOneWay = true, Action = "*")]
        void SayHello(string name);
    }
}
