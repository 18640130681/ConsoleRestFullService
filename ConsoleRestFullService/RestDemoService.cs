using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Activation;
using ConsoleRestFullService;

namespace RestFull
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestDemoService : IRestDemoService
    {

        public string GetData(string data)
        {
            Console.WriteLine(data);

            return data;
        }

        public string PostData(GuideDelayCancelInfo data)
        {
            return data.checkNo;
        }
    }


}
