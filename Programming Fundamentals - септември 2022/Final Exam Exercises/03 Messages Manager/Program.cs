using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Messages_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int capasity = int.Parse(Console.ReadLine());

            Dictionary<string, Messages> messages = new Dictionary<string, Messages>();

            string commands;

            while ((commands = Console.ReadLine()) != "Statistics")
            {
                string[] cmdArguments = commands.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                if(firstCommand == "Add")
                {
                    string username = cmdArguments[1];
                    int sent = int.Parse(cmdArguments[2]);
                    int received = int.Parse(cmdArguments[3]);

                    if(!messages.ContainsKey(username))
                    {
                        messages[username] = new Messages(sent, received);
                    }

                }
                else if(firstCommand == "Message")
                {
                    string sender = cmdArguments[1];
                    string receiver = cmdArguments[2];

                    if(messages.ContainsKey(sender) && messages.ContainsKey(receiver))
                    {
                        messages[sender].Sender += 1;
                        messages[receiver].Receiver += 1;

                        if(messages[sender].Sender + messages[sender].Receiver >= capasity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            messages.Remove(sender);
                        }

                        if (messages[receiver].Receiver + messages[receiver].Sender >= capasity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            messages.Remove(receiver);
                        }
                    }
                }
                else if(firstCommand == "Empty")
                {
                    string deleteUser = cmdArguments[1];

                    if(messages.ContainsKey(deleteUser))
                    {
                        messages.Remove(deleteUser);
                                                
                    }

                    if (deleteUser == "All")
                    {
                        messages.Clear();
                    }
                }
            }

            Console.WriteLine($"Users count: {messages.Count}");

            foreach (var message in messages.OrderByDescending(message => message.Value.Receiver).ThenBy(user => user.Key))
            {
                Console.WriteLine($"{message.Key} - {message.Value.Sender + message.Value.Receiver}");
            }
        }

        public class Messages
        {
            public Messages(int sender, int receiver)
            {
                Sender = sender;
                Receiver = receiver;
            }

            public int Sender { get; set; }
            public int Receiver { get; set; }
        }
    }
}
