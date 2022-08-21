using System;
using System.Collections.Generic;
using System.Text;

namespace webinar28
{
    internal class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfCreation = DateTime.Now;
        public string Description { get; set; }
        public string State { get; set; }

        public Task(int id, string name, string userName, DateTime dateOfCreation, string description, string state)
        {
            Id = id;
            Name = name;
            UserName = userName;
            DateOfCreation = dateOfCreation;
            Description = description;
            State = state;
        }
        public Task()
        {

        }
    }
}
