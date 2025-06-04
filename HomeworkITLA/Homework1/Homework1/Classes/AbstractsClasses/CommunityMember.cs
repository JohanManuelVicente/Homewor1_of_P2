using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Classes.AbstractsClasses
{
    public abstract class CommunityMember : Person
    {
        public  string Rol { get; set; }
        public CommunityMember(long Cedula, string Name, string Apellido, int Age, string? Address, string Rol) : base(Cedula, Name, Apellido, Age, Address)
        {
            this.Rol = Rol;
        } 
    }
}
