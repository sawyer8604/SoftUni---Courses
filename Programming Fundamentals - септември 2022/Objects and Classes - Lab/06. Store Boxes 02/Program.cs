using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" ");

                string serialNumber = arguments[0];
                string name = arguments[1];
                int itemQuantity = int.Parse(arguments[2]);
                decimal itemPrice = decimal.Parse(arguments[3]);

                Item item = new Item(name, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                  
                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(p=>p.PriceForBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox
        {
            get => ItemQuantity * Item.Price;
        }
    }
}
