using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Classes.AbstractsClasses
{
    public abstract class Person
    {
        public  required int Cedula { get; set; }
        public required string Name { get; set; }
        public required string Apellido { get; set; }
        public required int Age { get; set; }

        public string? Address { get; set; }

        public Person(int Cedula, string Name, string Apellido, int Age, string? Address)
        {
            this.Cedula = Cedula;
            this.Name = Name;
            this.Apellido = Apellido;
            this.Age = Age;
            this.Address = Address;

        }

        public abstract void ShowInfo();

    }
}
