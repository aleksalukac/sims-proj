using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Layouts
{
    public class Employee
    {
        public static uint countId = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public uint Id { get; set; }
        public bool OnVacation { get; set; }
        public uint StartWorkingHours = 8;
        public uint EndWorkingHours = 16;

        public Employee(bool random = false)
        {
            Id = countId++;
            if (random)
            {
                this.Name = RandomData.GetRandomName();
                this.Surname = RandomData.GetRandomSurname();
                this.Email = this.Name.ToLower() + "." + this.Surname.ToLower() + "@clinic.com";
                this.OnVacation = false;
            }
        }

        public bool Contains(string str)
        {
            return Name.ToUpper().Contains(str) || Surname.ToUpper().Contains(str) || Id.ToString().Contains(str) || Email.ToUpper().ToString().Contains(str);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
