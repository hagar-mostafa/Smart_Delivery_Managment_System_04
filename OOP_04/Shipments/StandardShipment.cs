using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace OOP_04.Shipments
{
    public class StandardShipment : Shipment
    {
   public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) { }

        #region impelement StandardShipment abstract method and member

        public override void PrintShipment()
        {
            Console.WriteLine("=== Standard Shipment ===");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight}");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee}");
            Console.WriteLine($"Destination    : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        }
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }

        }
        #endregion

        #region impelement StandardShipment interfaces

        #endregion

    }
}
