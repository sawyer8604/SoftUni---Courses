using System;
using System.Collections.Generic;
using System.Linq;


namespace _03_Followers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, int> folowers = new Dictionary<string, int>();



            while ((input = Console.ReadLine()) != "Log out")
            {
                string[] cmdArguments = input.Split(":");

                string firstCommand = cmdArguments[0];

                if(firstCommand == "New follower")
                {
                    string userName = cmdArguments[1];
                    
                    if(!folowers.ContainsKey(userName))
                    {
                        folowers[userName] = 0;
                    }
                }
                else if (firstCommand == "Like")
                {
                    string likeUser = cmdArguments[1];
                    int count = int.Parse(cmdArguments[2]);

                    if(folowers.ContainsKey(likeUser))
                    {
                        folowers[likeUser] += count;
                    }
                    else
                    {
                        folowers[likeUser] = count;
                    }
                }
                else if(firstCommand == "Comment")
                {
                    string commentUser = cmdArguments[1];

                    if(!folowers.ContainsKey(commentUser))
                    {
                        folowers[commentUser] = 1;
                    }
                    else
                    {
                        folowers[commentUser] += 1;
                    }
                    
                }
                else if(firstCommand == "Blocked")
                {
                    string deleteuser = cmdArguments[1];

                    if(!folowers.ContainsKey(deleteuser))
                    {
                        Console.WriteLine($"{deleteuser} doesn't exist.");
                    }
                    else
                    {
                        folowers.Remove(deleteuser);
                    }
                }
            }

            Console.WriteLine($"{folowers.Count} followers");

            foreach (var folower in folowers.OrderByDescending(likes => likes.Value).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{folower.Key}: {folower.Value}");
            }
        }

        
    }
}
