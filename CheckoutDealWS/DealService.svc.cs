using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CheckoutDealWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DealService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DealService.svc or DealService.svc.cs at the Solution Explorer and start debugging.
    public class DealService : IDealService
    {
        public string DoWork()
        {
            return "Hello World";
        }
    }
}
