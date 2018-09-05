using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LearningWCF
{
    [DataContract]
    public class Name
    {
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }
    }

    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        string SayHello(Name person);
    }

    public  class HelloWorldService : IHelloWorldService
    {
        public string SayHello(Name person)
        {
            return string.Format("Hello {0} {1} ", person.firstName, person.lastName);
        }
    }
}
