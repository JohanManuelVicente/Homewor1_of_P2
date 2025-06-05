using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Classes.SubClasses
{
    public class Administrators : Teaching
    {
        public string MainResponsibility { get; set; }     
        public int StaffUnderSupervision { get; set; }     
          

        public Administrators(long Cedula, string Name, string Apellido, int Age, string? Address, string Rol,
                             int salary, string position, string Department, string AcademicLevel,
                             int HoursOfClasesWeek, string Subjects, string MainResponsibility,
                             int StaffUnderSupervision)
            : base(Cedula, Name, Apellido, Age, Address, Rol, salary, position, Department,
                   AcademicLevel, HoursOfClasesWeek, Subjects)
        {
            this.MainResponsibility = MainResponsibility;
            this.StaffUnderSupervision = StaffUnderSupervision;
          
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Datos del Adnministrador {Name}:");
            Console.WriteLine();
            Console.WriteLine($"Nombre: {Name} {Apellido}, del departamento de {Department}");
            Console.WriteLine($"Materia que imparte: {Subjects}, nivel academico: {AcademicLevel}, y tiene {HoursOfClasesWeek} horas de clase a la semana");
            Console.WriteLine($"Principal responsabilidad {MainResponsibility}, Tiene {StaffUnderSupervision} empleados bajo su supervision");
        }
    }
}
