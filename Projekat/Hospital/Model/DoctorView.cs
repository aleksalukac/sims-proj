using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    public class DoctorView : EmployeeView
    {
        public string Specialisation { get; set; }

        public bool Contains(string str)
        {
            return Specialisation.ToUpper().Contains(str) || base.Contains(str);
        }

        public override string ToString()
        {
            return Name + " " + Surname + " | " + Id.ToString();
        }

        public DoctorView(bool random = false) : base(random)
        {
            if (random)
                this.Specialisation = RandomData.GetRandomSpecialization();
        }
    }
}
