using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApplication.HelloWorldServiceReference;

namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldServiceClient client = new HelloWorldServiceClient("WSHttpBinding_IHelloWorldService");
            Name first = new Name()
            {
                firstName = "Lakhan",
                lastName = "Bisht"
            };
            Console.WriteLine( client.SayHello(first));
            Console.ReadLine();
        }
    }
}
