using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Classes.SubClasses
{
     public class Teacher : Teaching
     {
           
            public string ContractType { get; set; }
            public string AssignedCenter { get; set; }

            public Teacher(long Cedula, string Name, string Apellido, int Age, string? Address, string Rol,
                           int salary, string position, string Department, string AcademicLevel,
                           int HoursOfClasesWeek, string Subjects, 
                           string ContractType, string AssignedCenter)
                : base(Cedula, Name, Apellido, Age, Address, Rol, salary, position, Department,
                       AcademicLevel, HoursOfClasesWeek, Subjects)
           
            {
                
                this.ContractType = ContractType;
                this.AssignedCenter = AssignedCenter;
            }

        public override void ShowInfo()
        {
            Console.WriteLine($"Datos del docente {Name}:");
            Console.WriteLine();
            Console.WriteLine($"Nombre: {Name} {Apellido}, del departamento de {Department}");
            Console.WriteLine($"Materia que imparte: {Subjects}, nivel academico: {AcademicLevel}, y tiene {HoursOfClasesWeek} horas de clase a la semana");
            Console.WriteLine($"Tipo de contrato: {ContractType}, Asignado al Centro de {AssignedCenter} ");
        }
    }
    
}
