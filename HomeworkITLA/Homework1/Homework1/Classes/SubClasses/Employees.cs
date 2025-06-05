using Homework1.Classes.AbstractsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Classes.SubClasses
{
    public class Employees : CommunityMember
    {
        public string Department { get; set; }
        public Employees(long Cedula, string Name, string Apellido, int Age, string? Address, string Rol) : base(Cedula, Name, Apellido, Age, Address, Rol)
        {

        }

        public override void ShowInfo()
        {
            
        }
    }
}
