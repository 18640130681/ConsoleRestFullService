using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Web;
using ConsoleRestFullService;

namespace RestFull
{
    [ServiceContract(Name = "RestFull.RestDemoService")]
    public interface IRestDemoService
    {
        [OperationContract]
        [WebGet(UriTemplate = Routing.GetClientRoute, BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        string GetData(string data);

        [OperationContract]
        [WebInvoke(UriTemplate = Routing.PostClientRoute, BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string PostData(GuideDelayCancelInfo data);
    }

    public static class Routing
    {
        public const string GetClientRoute = "GetData/{data}";
        public const string PostClientRoute = "/PostData";
    }
}
