using System.Runtime.InteropServices.Marshalling;

namespace CSharp_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //a) A class is a reference type, while a struct is a value type
            //b)Classes are more suitable for large data because they support features like inheritance
            #endregion

            #region q2

            //a) Shipment
            //b)ExpressShipment
            //c) trackingcode property
            //d) This makes the code easier to maintain, modify, and reduces repeat

            #endregion

            #region part02

            DeliveryCenter deliveryCenter = new DeliveryCenter();
            Console.WriteLine("enter the center name:");
            deliveryCenter.CenterName= Console.ReadLine();

            Console.WriteLine("1-Standard Shipment ");

            Console.WriteLine("tracking code :");
            string trackingCode01= Console.ReadLine();
            Console.WriteLine("description:");
            string description01= Console.ReadLine();
            int weight01;
            do
            {
                Console.WriteLine("weight : ");
            }
            while(!int.TryParse(Console.ReadLine(), out weight01));

            decimal deliveryFee01;
            do
            {
                Console.WriteLine("delivery fee :");

            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee01));

            Console.Write("City: ");

            string city01 = Console.ReadLine();

            Console.Write("Street: ");
            string street01 = Console.ReadLine();

            int buildingNumber01;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber01));

            DeliveryAddress destination01 = new DeliveryAddress(city01, street01, buildingNumber01);

            StandardShipment standardShipment = new StandardShipment(trackingCode01, description01, weight01, deliveryFee01, destination01);

            Console.WriteLine("2-ExpressShipment");

            Console.WriteLine("tracking code :");
            string trackingCode02 = Console.ReadLine();
            Console.WriteLine("description:");
            string description02 = Console.ReadLine();
            int weight02;
            do
            {
                Console.WriteLine("weight : ");
            }
            while (!int.TryParse(Console.ReadLine(), out weight02));

            decimal deliveryFee02;
            do
            {
                Console.WriteLine("delivery fee :");

            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee02));

            Console.Write("City: ");

            string city02 = Console.ReadLine();

            Console.Write("Street: ");
            string street02 = Console.ReadLine();

            int buildingNumber02;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber02));

            DeliveryAddress destination02 = new DeliveryAddress(city02, street02, buildingNumber02);
            decimal extrafee;
            do
            {
                Console.WriteLine("extrafee :");
            }while (!decimal.TryParse(Console.ReadLine(),out extrafee));

            ExpressShipment expressShipment = new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02, destination01,extrafee);

            Console.WriteLine("3-InternationalShipment");

            Console.Write("Tracking Code: ");
            string trackingCode03 = Console.ReadLine();

            Console.Write("Description: ");
            string description03 = Console.ReadLine();

            int weight03;
            do
            {
                Console.Write("Weight: ");

            }
            while (!int.TryParse(Console.ReadLine(), out weight03));

            decimal deliveryFee03;
            do
            {
                Console.Write("Delivery Fee: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee03));

            Console.Write("City: ");

            string city03 = Console.ReadLine();

            Console.Write("Street: ");
            string street03 = Console.ReadLine();

            int buildingNumber03;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber03));

            DeliveryAddress destination03 = new DeliveryAddress(city03, street03, buildingNumber03);

            Console.WriteLine("destination country : ");

            string destinationCountry= Console.ReadLine();

            decimal customsfee;
            do
            {
                Console.WriteLine("customerfee :");
            } while (!decimal.TryParse(Console.ReadLine(), out customsfee));

            InternationalShipment internationalShipment = new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03, destination03, destinationCountry, customsfee);

            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(internationalShipment);
            deliveryCenter.AddShipment(expressShipment);

            deliveryCenter.PrintAllShipments();

            Console.Write("Enter tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment search = deliveryCenter[searchCode];

            if(!string.IsNullOrWhiteSpace(searchCode))
            {
                search.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Console.Write("Enter tracking code to remove: ");
            string code = Console.ReadLine();

            if (deliveryCenter.RemoveShipment(code))
            {
                Console.WriteLine("Shipment removed successfully.");


            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Console.WriteLine("Remaining Shipments");

            deliveryCenter.PrintAllShipments();
            #endregion
        }
    }
}
