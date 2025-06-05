using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Classes.SubClasses
{
    public class Administrative : Employees
    {
        public string DesignatedArea{ get; set; }

        public string AdministrativeSchedule { get; set; }

        public string HasTeachingDuties { get; set; }
        public Administrative(string DesignatedArea, string AdministrativeSchedule, string HasTeachingDuties, long Cedula, string Name, string Apellido, int Age, string? Address, string Rol, int salary, string position, string Department)
            : base(Cedula, Name, Apellido, Age, Address, Rol, salary, position, Department)
        {
            this.DesignatedArea = DesignatedArea;
            this.AdministrativeSchedule = AdministrativeSchedule;
            this.HasTeachingDuties = HasTeachingDuties;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Datos del Administrativo {Name}:");
            Console.WriteLine();
            Console.WriteLine($"Nombre: {Name} {Apellido}, del departamento de {Department}");
            Console.WriteLine($"Area designada: {DesignatedArea}, su horario es de: {AdministrativeSchedule}, y {HasTeachingDuties} tiene tareas docentes");
        }
    }
}

