namespace _05.BirthdayCelebrations.Core
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
            string input;
            List<IBirthdate> all = new List<IBirthdate>();

            while ((input = reader.ReadLine()) != "End")
            {
                string[] cmdArguments = input.Split(' ');
                string firstCommand = cmdArguments[0];

                if(firstCommand == "Citizen")
                {
                    string name = cmdArguments[1];
                    int age = int.Parse(cmdArguments[2]);
                    string id = cmdArguments[3];
                    string bithDate = cmdArguments[4];

                    all.Add(new Citizen(name, age, id, bithDate));
                }
                else if(firstCommand == "Pet")
                {
                    string name = cmdArguments[1];
                    string bithDate = cmdArguments[2];

                    all.Add(new Pet(name, bithDate));
                }
            }

            string date = reader.ReadLine();
           
            foreach (var dates in all)
            {
                if(dates.Birthdate.EndsWith(date))
                {
                    writer.WriteLine(dates.Birthdate);
                }

            }
           
        }
    }
}
