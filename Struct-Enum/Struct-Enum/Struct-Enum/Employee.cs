using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Enum
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Addres { get; set; }
        public int Age { get; set; } = 16;

        public Employee(string name, string surname, string addres, int age)
        {
            Name = name;
            Surname = surname;
            Addres = addres;
            Age = age;

        }
        public override string ToString()
        {
            return $"{Name} {Surname} {Addres} {Age}";
        }

    }
}
