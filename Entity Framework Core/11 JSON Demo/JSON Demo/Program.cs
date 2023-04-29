using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSON_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            {
                Extras = new List<string> { "Klimatronik", "4x4" },
                ManufacturedOn = DateTime.UtcNow,
                Model = "Golf",
                Vendor = "VW",
                Price = 1234.567m,
                Engine = new Engine { Volume = 1.6m, HorsePower = 75 }

            };

            // JSON

            var options = new JsonSerializerOptions // за по - добър изглед
            {
                WriteIndented = true,
            };

           File.WriteAllText("myCar.json", JsonSerializer.Serialize(car, options)); // Serialize

            Console.WriteLine(JsonSerializer.Serialize(car, options));

            var options2 = new JsonSerializerOptions
            {
                WriteIndented = true, 
            };
            var json = File.ReadAllText("myCar.json");
            Car nCar = JsonSerializer.Deserialize<Car>(json, options2);   // Deserialize
        }
    }
}
