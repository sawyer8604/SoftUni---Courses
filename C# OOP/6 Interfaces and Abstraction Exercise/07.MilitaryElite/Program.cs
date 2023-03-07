using _07.MilitaryElite.Models;
using _07.MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace _07.MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, ISoldier> soldiers = new Dictionary<int, ISoldier>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputinfo = input.Split();
                string action = inputinfo[0];
                int id = int.Parse(inputinfo[1]);
                string firstName = inputinfo[2];
                string lastName = inputinfo[3];

                if(action == "Private")
                {
                    decimal salary = decimal.Parse(inputinfo[4]);
                    IPrivate @private = new Private(id, firstName, lastName, salary);
                    soldiers.Add(id, @private);
                }
                else if(action == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputinfo[4]);

                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < inputinfo.Length; i++)
                    {
                        int inputId = int.Parse(inputinfo[i]);
                        IPrivate soldier = (IPrivate)soldiers[inputId];

                        lieutenantGeneral.Privates.Add(soldier);
                    }

                    soldiers.Add(id, lieutenantGeneral);
                }
                else if(action == "Engineer")
                {
                    decimal salary = decimal.Parse(inputinfo[4]);
                    string corpAsString = inputinfo[5];

                    bool isValidEnum = Enum.TryParse<Corps>(corpAsString, out Corps result);

                    if(!isValidEnum)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, result);

                    for (int i = 6; i < inputinfo.Length; i+=2)
                    {
                        string partName = inputinfo[i];
                        int hours = int.Parse(inputinfo[i + 1]);

                        IRepair repair = new Repair(partName, hours);

                        engineer.Repairs.Add(repair);
                    }

                    soldiers.Add(id, engineer);
                }
                else if(action == "Commando")
                {

                    decimal salary = decimal.Parse(inputinfo[4]);
                    string corpAsString = inputinfo[5];

                    bool isValidEnum = Enum.TryParse<Corps>(corpAsString, out Corps result);

                    if (!isValidEnum)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    ICommando commando = new Commando(id, firstName, lastName, salary, result);

                    for (int i = 6; i < inputinfo.Length; i+=2)
                    {
                        string missionCode = inputinfo[i];
                        string missionStateAsString = inputinfo[i + 1];

                        bool isValidMision = Enum.TryParse(missionStateAsString, out State status);

                        if(!isValidMision)
                        {
                           
                            continue;
                        }

                        IMission mission = new Mission(missionCode, status);

                        commando.Missions.Add(mission);
                    }

                    soldiers.Add(id, commando);
                }
                else if(action == "Spy")
                {
                    int codeNumber = int.Parse(inputinfo[4]);

                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiers.Add(id, spy);
                }

                input = Console.ReadLine();

            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Value.ToString());
            }
        }
    }
}
