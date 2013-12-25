﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Registeration
{
    [ServiceContract]
    public interface IAirSellerRegisteration
    {
        [OperationContract]
        void RegisterSeller(Uri request, string clusterName);
    }
}