using Controllers;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hospital.ViewModel
{
    public class DoctorView : EmployeeView
    {
        DoctorController _doctorController = (Application.Current as App).DoctorController;

        public DoctorView() : base()
        {

        }

        public DoctorView(Doctor doctor)
        {
            this.Email = doctor.Email;
            this.Id = (uint) doctor.Id;
            this.Name = doctor.Name;
            this.Password = doctor.Password;
            this.StartWorkingHours = (uint)doctor.WorkingHours.StartingHour.Hours;
            this.EndWorkingHours = (uint)doctor.WorkingHours.EndingHour.Hours;
            this.Surname = doctor.Surname;
            this.Specialisation = doctor.specialisationType.Name;
        }
        
        public Doctor Convert()
        {
            var doctor = _doctorController.Get((int)this.Id);

            if (doctor == null)
            {
                doctor = new Doctor();
            }

            doctor.Email = this.Email;
            doctor.Password = this.Password;
            doctor.WorkingHours = new WorkingHours((int)this.StartWorkingHours, (int)this.EndWorkingHours);
            doctor.Name = this.Name;
            doctor.Surname = this.Surname;
            doctor.Email = this.Email;
            doctor.specialisationType.Name = this.Specialisation;

            return doctor;
        }

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
