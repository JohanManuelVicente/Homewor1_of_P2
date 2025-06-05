using Homework1.Classes.AbstractsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Classes.SubClasses
{
    public class Employees : CommunityMember
    {
        public string Department { get; set; }

        public string position { get; set; }
        public int salary { get; set; }

        public Employees(long Cedula, string Name, string Apellido, int Age, string? Address, string Rol, int salary, string position, string Department) : base(Cedula, Name, Apellido, Age, Address, Rol)
        {
            this.Department = Department;
            this.position = position;
            this.salary = salary;   

        }

        public override void ShowInfo()
        {

            Console.WriteLine($"Datos del empleado {Name}:");
            Console.WriteLine();
            Console.WriteLine($"Nombre: {Name} {Apellido}");
            Console.WriteLine($"Rol: {Rol}, Del departamento {Department}, como {position}, con salario de {salary} pesos");
        }
    }
}
