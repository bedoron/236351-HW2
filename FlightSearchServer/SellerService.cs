﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirlineServer
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Trip", Namespace = "http://schemas.datacontract.org/2004/07/AirlineServer")]
    public partial class Trip : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private AirlineServer.Flight firstFlightField;

        private int priceField;

        private AirlineServer.Flight secondFlightField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirlineServer.Flight firstFlight
        {
            get
            {
                return this.firstFlightField;
            }
            set
            {
                this.firstFlightField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirlineServer.Flight secondFlight
        {
            get
            {
                return this.secondFlightField;
            }
            set
            {
                this.secondFlightField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Flight", Namespace = "http://schemas.datacontract.org/2004/07/AirlineServer")]
    public partial class Flight : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.DateTime dateField;

        private string dstField;

        private string flightNumberField;

        private int priceField;

        private string sellerField;

        private string srcField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dst
        {
            get
            {
                return this.dstField;
            }
            set
            {
                this.dstField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string flightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string seller
        {
            get
            {
                return this.sellerField;
            }
            set
            {
                this.sellerField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string src
        {
            get
            {
                return this.srcField;
            }
            set
            {
                this.srcField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ISellerService")]
public interface ISellerService
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ISellerService/getTrips", ReplyAction = "http://tempuri.org/ISellerService/getTripsResponse")]
    AirlineServer.Trip[] getTrips(string src, string dst, System.DateTime date, string[] sellers);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ISellerService/getTrips", ReplyAction = "http://tempuri.org/ISellerService/getTripsResponse")]
    System.Threading.Tasks.Task<AirlineServer.Trip[]> getTripsAsync(string src, string dst, System.DateTime date, string[] sellers);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISellerServiceChannel : ISellerService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SellerServiceClient : System.ServiceModel.ClientBase<ISellerService>, ISellerService
{

    public SellerServiceClient()
    {
    }

    public SellerServiceClient(string endpointConfigurationName) :
        base(endpointConfigurationName)
    {
    }

    public SellerServiceClient(string endpointConfigurationName, string remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public SellerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public SellerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(binding, remoteAddress)
    {
    }

    public AirlineServer.Trip[] getTrips(string src, string dst, System.DateTime date, string[] sellers)
    {
        return base.Channel.getTrips(src, dst, date, sellers);
    }

    public System.Threading.Tasks.Task<AirlineServer.Trip[]> getTripsAsync(string src, string dst, System.DateTime date, string[] sellers)
    {
        return base.Channel.getTripsAsync(src, dst, date, sellers);
    }
}
