
namespace BorderControl.Core
{    
    using System.Collections.Generic;
    using IO.Interfeces;
    using Models;
    using Models.Interfaces;
    using Interfaces;

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
            List<ICitizen> citizens = new List<ICitizen>();
            List<IRobot> robots = new List<IRobot>();

            string command;

            while ((command = this.reader.ReadLine()) != "End")
            {
                string[] cmdArguments = command.Split(" ");

                if (cmdArguments.Length == 2)
                {
                    string name = cmdArguments[0];
                    string id = cmdArguments[1];

                    robots.Add(new Robot(name, id));

                }
                else
                {
                    string name = cmdArguments[0];
                    int age = int.Parse(cmdArguments[1]);
                    string id = cmdArguments[2];

                    citizens.Add(new Citizen(name, age, id));
                }
            }

            string numberForCheck = this.reader.ReadLine();


            foreach (var citizen in citizens)
            {

                if (citizen.Checkpoit(numberForCheck))
                {
                    writer.WriteLine(citizen.Id);
                }

            }


            foreach (var robot in robots)
            {

                if (robot.Checkpoit(numberForCheck))
                {
                    writer.WriteLine(robot.Id);
                }
            }
        }

    }
}
