﻿using System;

namespace ToDoList.Core.Commands
{
    public class NotFoundCommand : ICommand
    {
        public string Name { get; set; }
        public void Execute()
        {
            Console.WriteLine("Couldn't find command: " + Name);
        }
    }
}
