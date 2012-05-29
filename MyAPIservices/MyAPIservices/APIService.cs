using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Activation;
using MyAPIservices.Data;

namespace MyAPIservices
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single, ConcurrencyMode=ConcurrencyMode.Multiple)]
    public class APIService : IAPIService
    {

        public ResponseClass KeepServiceAlive()
        {
            ResponseClass response = new ResponseClass();
            response.Response = true.ToString();
            return response;
        }

        public ResponseClass Add(int x, int y)
        {
            ResponseClass response = new ResponseClass();
            response.Response = (x + y).ToString();
            return response;
        }

        public ResponseClass Subtract(int x, int y)
        {
            ResponseClass response = new ResponseClass();
            response.Response = (x - y).ToString();
            return response;
        }

        public ResponseClass Multiply(int x, int y)
        {
            ResponseClass response = new ResponseClass();
            response.Response = (x * y).ToString();
            return response;
        }

        public ResponseClass Divide(int x, int y)
        {
            ResponseClass response = new ResponseClass();
            try
            {
                response.Response = (x / y).ToString();
            }
            catch (Exception ex)
            {
                response.Response = ex.Message;
            }
            return response;
        }
    }
}
