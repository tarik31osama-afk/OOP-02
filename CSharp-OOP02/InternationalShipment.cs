namespace CSharp_OOP02
{
    public class InternationalShipment:Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        public InternationalShipment(string trackingCode, string description, int weight, decimal deliveryFee,
            DeliveryAddress Destination ,string destinationCountry,decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, Destination)
        {
            DestinationCountry=destinationCountry;
            CustomsFee = customsFee;

        }
        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;

                }
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if(value>=0)
                {
                    customsFee=value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
    }
}
}
