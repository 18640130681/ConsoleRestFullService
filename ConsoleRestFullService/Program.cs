using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestFull;
using System.ServiceModel.Web;
using System.ServiceModel;

namespace ConsoleRestFullService
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                IRestDemoService demoServices = new RestDemoService();
                WebServiceHost _serviceHost = new WebServiceHost(demoServices, new Uri("http://localhost/zstestDemoService"));

                //WebHttpBinding binding = new WebHttpBinding();
                //binding.MaxBufferPoolSize = long.MaxValue;
                //binding.MaxBufferSize = int.MaxValue;
                //binding.MaxReceivedMessageSize = int.MaxValue;
                //binding.ReaderQuotas.MaxArrayLength = int.MaxValue;
                //binding.ReaderQuotas.MaxBytesPerRead = int.MaxValue;
                //binding.ReaderQuotas.MaxDepth = int.MaxValue;
                //binding.ReaderQuotas.MaxNameTableCharCount = int.MaxValue;
                //binding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
                //_serviceHost.AddServiceEndpoint(typeof(IReserveInfoService), binding, "");



                _serviceHost.Open();
                Console.WriteLine("服务已启动");

                Console.ReadKey();
                _serviceHost.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
