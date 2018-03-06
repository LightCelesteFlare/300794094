using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            var clients = new[]
            {
                new Client( 1 , "BK Associates", "Commercial", "Toronto", 230000, true),
                new Client( 6 , "Bick", "Industrial", "Dallas", 679000, false),
                new Client( 19 , "TPH", "Government", "Athlanta", 986000, true),
                new Client( 12 , "Crow", "Industrial", "Phoenix", 126000, false),
                new Client( 56 , "TX Electric", "Industrial", "Portland", 564000, true),
                new Client( 42 , "GRB", "Government", "Omaha", 437000, false),
                new Client( 98 , "LB&B", "Commercial", "Toronto", 990000, true),
                new Client( 44 , "H&P", "Commercial", "Denver", 122000, true),
            };

            Console.WriteLine("| ClientID |   Client Name   | Client Services | Client City | Client Revenue | Client Type |");
            Console.WriteLine("|----------|-----------------|-----------------|-------------|----------------|-------------|");
            foreach (var n in clients)
            {
                Console.WriteLine(n);
            } // end foreach

            //Question 1
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            Console.WriteLine("1. sort the data by Client ID\n");
            var ClientSort = from b in clients
                             orderby b.ClientID
                             select b;

            foreach (var n in ClientSort)
            {
                Console.WriteLine(n);
            }
            // Question 2
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            Console.WriteLine("2. sort the data by Name and City \n");
            var NameCitySort = from b in clients
                               orderby b.ClientName, b.City
                               select new { b.ClientID, b.ClientName, b.ClientServices, b.City, b.Revenue, b.action };

            Console.WriteLine("| ClientID |   Client Name   | Client Services | Client City | Client Revenue | Client Type |");
            Console.WriteLine("|----------|-----------------|-----------------|-------------|----------------|-------------|");
            foreach (var n in NameCitySort)
            {
                Console.WriteLine("| {0,-8} | {1,-15} | {2,-15} | {3,-11} | {4,-14 :C} | {5,-11} |", n.ClientID, n.ClientName, n.ClientServices, n.City, n.Revenue, n.action);
            }

            // Question 3
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            Console.WriteLine("3. Select the Government clients and sort the results by Revenue\n");
            var GovernmentRev = from b in clients
                                where b.ClientServices == "Government"
                                select b;
            Console.WriteLine("| ClientID |   Client Name   | Client Services | Client City | Client Revenue | Client Type |");
            Console.WriteLine("|----------|-----------------|-----------------|-------------|----------------|-------------|");
            foreach (var n in GovernmentRev)
            {
                Console.WriteLine(n);
            }

            // Question 4
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            Console.WriteLine("4. Select only the Active clients and calculate their total Revenue\n");

            var ActiveSum = from b in clients
                            where b.action == true
                            group b by 1 into g                        
                            select new { Total = g.Sum(x => x.Revenue) };

            foreach (var m in ActiveSum)
            {
                Console.WriteLine("Total Revenue: {0:C}",m.Total);
            } // end foreach

            // Question 5
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            Console.WriteLine("5. retrieve and display the most important Client\n");
            var VIP = from b in clients
                      where b.action == true
                      orderby b.Revenue descending
                      select b;

            Console.WriteLine("| ClientID |   Client Name   | Client Services | Client City | Client Revenue | Client Type |");
            Console.WriteLine("|----------|-----------------|-----------------|-------------|----------------|-------------|");
            foreach (var g in VIP)
            {
                Console.WriteLine(g);
            } // end foreach

            Console.ReadKey();
        }
    }
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientServices { get; set; }
        public string City { get; set; }
        public double Revenue { get; set; }
        public bool action { get; set; }
    
        public Client(int ClientID, string ClientName, string Service, string City, double Revenue, bool action)
        {
            this.ClientID = ClientID;
            this.ClientName = ClientName;
            this.ClientServices = Service;
            this.City = City;
            this.Revenue = Revenue;
            if (action == true) { 
                this.action = true;
            }
            else
            {
                this.action = false;
            }
        }

        public override string ToString() =>
             $"{"| "}{ClientID,-9}{"| "}{ClientName,-16}{"| "}{ClientServices,-12}{"| ",6}{City,-12}{"| $"}{Revenue,-14}{"| "}{action,-12}{"|"}";
              
    }

}
