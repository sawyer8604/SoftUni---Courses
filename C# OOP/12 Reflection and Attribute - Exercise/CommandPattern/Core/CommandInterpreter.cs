﻿using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] input = args.Split();

            string commandName = input[0];
            string[] value = input.Skip(1).ToArray();

            Type type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == commandName + "Command");

            if(type == null)
            {
                throw new InvalidOperationException("Missing command");
            }

            Type commandInterfaces = type.GetInterface("ICommand");

            if (commandInterfaces == null)
            {
                throw new InvalidOperationException("Not a command");
            }

            var command = Activator.CreateInstance(type) as ICommand;

            string result = command.Execute(value);

            return result;
        }
    }
}
