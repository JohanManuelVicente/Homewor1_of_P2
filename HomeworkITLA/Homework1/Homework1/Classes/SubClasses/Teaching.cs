using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Classes.SubClasses
{
    public class Teaching : Employees
    {
        public string Subjects { get; set; }

        public int HoursOfClasesWeek { get; set; }

        public string AcademicLevel { get; set; }

        public Teaching(long Cedula, string Name, string Apellido, int Age, string? Address, string Rol, int salary, string position, string Department, string AcademicLevel, int HoursOfClasesWeek, string Subjects) 
            : base(Cedula, Name, Apellido, Age, Address, Rol, salary, position, Department)

        {
            this.Subjects = Subjects;
            this.HoursOfClasesWeek = HoursOfClasesWeek;
            this.AcademicLevel = AcademicLevel;

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Datos del docente {Name}:");
            Console.WriteLine();
            Console.WriteLine($"Nombre: {Name} {Apellido}, del departamento de {Department}");
            Console.WriteLine($"Materia que imparte: {Subjects}, nivel academico: {AcademicLevel}, y tiene {HoursOfClasesWeek} horas de clase a la semana");
        }
    }
    
}
