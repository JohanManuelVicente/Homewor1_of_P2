using Homework1.Classes.AbstractsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework1.Classes.SubClasses
{
    public class ExStudent : CommunityMember
    {
        public  string Career { get; set; }
        public  string UniversityEnrollment { get; set; }

        public  DateTime DepartureDate { get; set; }

        public ExStudent(long Cedula, string Name, string Apellido, int Age, string? Address, string Rol, string Career, string UniversityEnrollment, DateTime DepartureDate) : base(Cedula, Name, Apellido, Age, Address, Rol)
        {
            this.Career = Career;
            this.UniversityEnrollment = UniversityEnrollment;
            this.DepartureDate = DepartureDate;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Nombre: {Name} {Apellido}");
            Console.WriteLine($"Cedula: {Cedula}, Edad: {Age}, Direccion: {Address}");
            Console.WriteLine($"Rol: {Rol}, Carrera: {Career}, ");
            Console.WriteLine($"Año de retirada: {DepartureDate}");
        }

    }
}
