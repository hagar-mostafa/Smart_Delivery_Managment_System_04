using System;
using System.Collections.Generic;
using System.Text;
#nullable disable

namespace OOP_04.Shipments
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal _ExtraFee;
        public decimal ExtraFee
        {
            get
            {
                return _ExtraFee;
            }
            set
            {
                if (_ExtraFee >= 0)
                    _ExtraFee = value;
            }
        }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = _ExtraFee;
        }



        #region impelement EstimatedCost abstract method and member
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }
        
        public override void PrintShipment()

        {
            Console.WriteLine("=== Express Shipment ===");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight}");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee}");
            Console.WriteLine($"Urgency Fee    : {ExtraFee}");
            Console.WriteLine($"Destination    : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        }
        #endregion

       #region impelement EstimatedCost interfaces
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
        #endregion
    }
}
