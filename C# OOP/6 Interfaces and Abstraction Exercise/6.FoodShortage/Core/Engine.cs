
namespace FoodShortage.Core
{
    using Core.Interfaces;
    using IO.Interfaces;
    using Models;
    using Models.Interfaces;   
    using System.Collections.Generic;
    
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            Dictionary<string, IBuyer> citizens = new Dictionary<string, IBuyer>();
            Dictionary<string, IBuyer> rebels = new Dictionary<string, IBuyer>();

            int sum = 0;

            int numberOfLines = int.Parse(reader.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string commands = reader.ReadLine();

                string[] cmdArguments = commands.Split(" ");
                string name = cmdArguments[0];
                int age = int.Parse(cmdArguments[1]);
                string group = cmdArguments[2];

                if (cmdArguments.Length == 3)
                {
                    IBuyer rebel = new Rebel(name, age, group);
                    if (!(citizens.ContainsKey(name) && rebels.ContainsKey(name)))
                    {
                        rebels[name] = rebel;
                    }

                }
                else
                {
                    string id = cmdArguments[2];
                    string birthDate = cmdArguments[3];

                    IBuyer citizen = new Citizen(name, age, id, birthDate);
                    if (!(citizens.ContainsKey(name) && rebels.ContainsKey(name)))
                    {
                        citizens[name] = citizen;
                    }

                }

            }
            string command;

            while ((command = reader.ReadLine()) != "End")
            {
                if (citizens.ContainsKey(command))
                {
                    sum += citizens[command].BuyFood(10);
                }
                else if(rebels.ContainsKey(command))
                {
                    sum += rebels[command].BuyFood(5);
                }
            }
            writer.WriteLine(sum);
        }
    }
}
