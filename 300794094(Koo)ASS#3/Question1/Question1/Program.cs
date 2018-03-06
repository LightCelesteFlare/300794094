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
            var items = new[] {
            new Inventory( 83, "Electric sander", 7, 59.98 ),
            new Inventory(24,"Power saw", 18, 99.99 ),
            new Inventory(7, "Sledge hammer", 11, 21.55 ),
            new Inventory(77,"Hammer", 76, 11.99 ),
            new Inventory(39,"Lawn mower", 3, 79.95 ),
            new Inventory(68,"Screwdriver", 106, 7.99 ),
            new Inventory(56,"Jig Saw", 21, 11.95 ),
            new Inventory(3, "Wrench", 34, 7.95 )
        }; // item list
            Console.WriteLine("| ItemId | item_Description | Quantity | unit_Price |");
            Console.WriteLine("|--------|------------------|----------|------------|");
            foreach (var n in items)
            {
                Console.WriteLine(n);
                Console.WriteLine("|--------|------------------|----------|------------|");
            } // end foreach
            // Question 1
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("1. sort the data by item description\n");
            var ItemDescriptionSort = from b in items
                                      orderby b.item_Description
                                      select b;

            foreach (var n in ItemDescriptionSort)
            {
                Console.WriteLine(n);
            }
            // Question 2
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("2. select the item description and quantity, and sort the reselts by quantity \n");
            var Quantityitem = from b in items
                               orderby b.Quantity
                               select new { b.item_Description, b.Quantity };

            Console.WriteLine("| item_Description | Quantity |");
            Console.WriteLine("|------------------|----------|");
            foreach (var n in Quantityitem)
            {
                Console.WriteLine("| {0,-16} | {1,-8} |", n.item_Description, n.Quantity);
            }

            // Question 3
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("3. select the item description and its total value\n");
            var totalPrice = (from b in items
                              select new { b.ItemId, b.item_Description, totalPrice = (b.Quantity * b.unit_Price) }).OrderByDescending(i => i.totalPrice);

            Console.WriteLine("| ItemId | item_Description | TotalPrice |");
            Console.WriteLine("|--------|------------------|------------|");
            foreach (var n in totalPrice)
            {
                Console.WriteLine("| {0,-6} | {1,-16} | {2,-10 :C} |", n.ItemId, n.item_Description, n.totalPrice);
            }

            // Question 4
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("4. Retrieve and display the most expensive item\n");

            var MostExpen = from e in items
                            orderby e.unit_Price
                            select e;

            Console.WriteLine("| ItemId | item_Description | Quantity | unit_Price |");
            Console.WriteLine("|--------|------------------|----------|------------|");
            Console.WriteLine(MostExpen.Last());

            // Question 5
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("5. reduce and Unit price of all Items by 10%\n");
            var reduction = from b in items
                            select new { b.ItemId, b.item_Description, b.Quantity, Reduces = (b.unit_Price - (b.unit_Price * .1)) };

            Console.WriteLine("| ItemId | item_Description | Quantity | unit_Price |");
            Console.WriteLine("|--------|------------------|----------|------------|");
            foreach (var r in reduction)
            {
                Console.WriteLine("| {0,-6} | {1,-16} | {2,-7}  | {3,-10 :C} |", r.ItemId, r.item_Description, r.Quantity, r.Reduces);
                Console.WriteLine("|--------|------------------|----------|------------|");
            }
            Console.ReadKey();
        }
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

            public Inventory(int Itemid, string item_Desc, int Quantity, double unitPrice)
            {
                this.ItemId = Itemid;
                this.item_Description = item_Desc;
                this.Quantity = Quantity;
                this.unit_Price = unitPrice;
            }

            public override string ToString() =>
                $"{"| "}{ItemId,-7}{"| "}{item_Description,-17}{"| "}{Quantity,-6}{"| $",6}{unit_Price,-10}{"|"}";

        }       
    }


