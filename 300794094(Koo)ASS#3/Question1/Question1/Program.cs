using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Inventory> items = new List<Inventory>();
            items.Add(new Inventory() { ItemId = 83, item_Description = "Electric sander", Quantity = 7, unit_Price = 59.98 });
            items.Add(new Inventory() { ItemId = 24, item_Description = "Power saw", Quantity = 18, unit_Price = 99.99 });
            items.Add(new Inventory() { ItemId = 7, item_Description = "Sledge hammer", Quantity = 11, unit_Price = 21.55 });
            items.Add(new Inventory() { ItemId = 77, item_Description = "Hammer", Quantity = 76, unit_Price = 11.99 });
            items.Add(new Inventory() { ItemId = 39, item_Description = "Lawn mower", Quantity = 3, unit_Price = 79.95 });
            items.Add(new Inventory() { ItemId = 68, item_Description = "Screwdriver", Quantity = 106, unit_Price = 7.99 });
            items.Add(new Inventory() { ItemId = 56, item_Description = "Jig Saw", Quantity = 21, unit_Price = 11.95 });
            items.Add(new Inventory() { ItemId = 3, item_Description = "Wrench", Quantity = 34, unit_Price = 7.95 });

            foreach (var n in items)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Sort | MostExp | ReducePrice");
                Console.Write("Enter a Command: ");
                var com = Console.ReadLine();

                if ("Sort" == com)
                {
                    Console.WriteLine("Items | ItemDescription | Quantity | UnitPrice");
                    Console.Write("Enter the column name (no spaces): ");
                    var comm = Console.ReadLine();

                    // items#
                    if ("Items" == comm)
                    {
                        var query = from b in items
                                    orderby b.ItemId
                                    select b;
                    }
                        
                    if("ItemDescription" == comm)
                    {
                        var query = from b in items
                                    orderby b.item_Description
                                    select b;
                    }

                    if ("Quantity" == comm)
                    {
                        var query = from b in items
                                    orderby b.Quantity
                                    select b;
                    }

                    if ("UnitPrice" == comm)
                    {
                        var query = from b in items
                                    orderby b.unit_Price
                                    select b;
                    }
                                      
                }
                else if ("MostExp" == com)
                {

                double maxPrice = items.Max(t => t.unit_Price);
                Console.WriteLine("{0} Highest price: {1} ",items ,maxPrice);
                }

                else if ("ReducePrice" == com)
                {
                foreach (var n in items)
                {
                    Console.WriteLine(n.unit_Price /10);
                }
            }
                else
                {
                    Console.WriteLine("Invalid command");
                    Console.WriteLine("Exiting Program");                  
                }
            Console.ReadKey();
        }
            
        public class Inventory
        {
            // the Item#
            public int ItemId { get; set; }
            // Item Description
            public string item_Description { get; set; }

            // Quantity
            public int Quantity { get; set; }
            // Unit Price
            public double unit_Price { get; set; }

            public override string ToString()
            {
                return string.Join(" ", new string[] {
                string.Format("| ItemId = {0} | item_Description = {1} | Quantity = {2} | unit_Price = {3} |", this.ItemId, this.item_Description, this.Quantity, this.unit_Price)});
            }
        }       
    }
}

