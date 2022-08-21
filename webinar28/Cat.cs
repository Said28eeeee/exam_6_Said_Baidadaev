using System;
using System.Collections.Generic;
using System.Text;

namespace webinar28
{
    internal class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int SatietyLevel { get; set; }
        public int HappyLevel { get; set; }
        public string State { get; set; }
        public string Message { get; set; }
        public Cat(string Name)
        {
            this.Name = Name;
            Age = new Random().Next(1, 11);
            SatietyLevel = 0;
            HappyLevel = 0;
            State = "кот ждет";
        }
    }
}
