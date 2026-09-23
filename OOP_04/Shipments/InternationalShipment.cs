using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_04.Shipments
{
    public class InternationalShipment : Shipment
    {
        private string _DestinationCountry;
        private decimal _CustomsFee;

        public string DestinationCountry
        {
            get
            {
                return _DestinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _DestinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return _CustomsFee;
            }
            set
            {
                if (_CustomsFee >= 0)
                    _CustomsFee = value;
            }
        }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        #region impelement InternationalShipment abstract method and class
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("=== International Shipment ===");
            Console.WriteLine($"Tracking Code       : {TrackingCode}");
            Console.WriteLine($"Description         : {Description}");
            Console.WriteLine($"Weight              : {Weight}");
            Console.WriteLine($"Delivery Fee        : {DeliveryFee}");
            Console.WriteLine($"Customs Fee         : {CustomsFee}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Destination         : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost}");
        }
#endregion
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("=== Customs Report ===");
            Console.WriteLine($"Tracking Code      : {TrackingCode}");
            Console.WriteLine($"Description        : {Description}");
            Console.WriteLine($"Weight             : {Weight}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee        : {CustomsFee}");
        }

    }
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee) { }

        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
            Console.WriteLine("Priority: EXPRESS CUSTOMS CLEARANCE");
        }
    }
}
