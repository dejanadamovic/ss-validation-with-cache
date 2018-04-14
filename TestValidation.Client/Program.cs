using System;
using ServiceStack;
using ServiceStack.Text;
using TestValidation.Server;

namespace TestValidation.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new JsonServiceClient("http://127.0.0.1:8088").WithCache();

            try
            {
                client.Get(new Hello {Name = string.Empty}).PrintDump();
            }
            catch (WebServiceException e)
            {
                e.GetResponseStatus().PrintDump();
            }

            try
            {
                client.Post(new Hello {Name = string.Empty}).PrintDump();
            }
            catch (WebServiceException e)
            {
                e.Message.PrintDump();
            }
            
            Console.ReadLine();
        }
    }
}
