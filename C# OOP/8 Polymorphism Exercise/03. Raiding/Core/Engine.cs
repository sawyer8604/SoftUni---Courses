
namespace Raiding.Core
{
    using Models.Interfaces;
    using Core.Interfaces;
    using Factory;
    using IO.Interfaces;
    using Raiding.Models;
    using System.Collections.Generic;
    using System.Reflection;
    using System;
    using System.Linq;

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
            int numberOfCommands = int.Parse(reader.ReadLine());
            
            int counter = 0;
            List<IBaseHero> raiders = new List<IBaseHero>();
            while (counter != numberOfCommands)
            {                
                string name = reader.ReadLine();
                string type = reader.ReadLine();

                try
                {
                    HeroType types = new HeroType();

                    IBaseHero hero = types.CreateHero(type, name);
                                 
                    counter++;

                    raiders.Add(hero);
                }
                catch (Exception ex)
                {

                    Console.WriteLine( ex.Message);
                }            
                
                
            }

            long bossPower = long.Parse(reader.ReadLine());


            foreach (var r in raiders)
            {
                Console.WriteLine(r.CastAbility());
            }

            long allPower = raiders.Select(x => x.Power).Sum();

            if (allPower >= bossPower)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
            
        }
    }
}
