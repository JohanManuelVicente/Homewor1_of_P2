using Homework1.Classes.AbstractsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Classes.SubClasses
{
    public class Student : CommunityMember
    {
        public  string Career { get; set; }
        public  string UniversityEnrollment { get; set; }

        public Student(long Cedula, string Name, string Apellido, int Age, string? Address, string Rol, string Career, string UniversityEnrollment) : base (Cedula, Name, Apellido, Age, Address, Rol)
        {   
            this.Career = Career;
            this.UniversityEnrollment = UniversityEnrollment;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Datos del estudiante {Name}:");
            Console.WriteLine();
            Console.WriteLine($"Nombre: {Name} {Apellido}");
            Console.WriteLine($"Cedula: {Cedula}, Edad:{Age}, Direccion: {Address}");
            Console.WriteLine($"Rol: {Rol}, Carrera: {Career}, Matricula {UniversityEnrollment}");
        }

    }
    
    
}
