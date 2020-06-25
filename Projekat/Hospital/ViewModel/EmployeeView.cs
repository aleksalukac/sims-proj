using Controllers;
using Model;
using System;
using System.Windows;

namespace Hospital.ViewModel
{
    public class EmployeeView
    {
        EmployeeController _employeeController = (Application.Current as App).EmployeeController;

        public EmployeeView()
        {
            this.Password = "";
        }

        public Employee Convert()
        {
            Employee employee = _employeeController.Get((int)this.Id);

            if (employee == null)
            {
                employee = new Doctor();
            }

            employee.Email = this.Email;
            employee.Password = this.Password;
            employee.WorkingHours = new WorkingHours((int)this.StartWorkingHours, (int)this.EndWorkingHours);
            employee.Name = this.Name;
            employee.Surname = this.Surname;
            employee.Email = this.Email;

            return employee;
        }

        public static uint countId = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public uint Id { get; set; }
        public bool OnVacation { get; set; }
        public uint StartWorkingHours = 8;
        public uint EndWorkingHours = 16;
        private Employee employee;

        public EmployeeView(bool random = false)
        {
            Id = countId++;
            if(random)
            {
                this.Name = RandomData.GetRandomName();
                this.Surname = RandomData.GetRandomSurname();
                this.Email = this.Name.ToLower() + "." + this.Surname.ToLower() + "@clinic.com";
                this.OnVacation = false;
            }
        }

        public EmployeeView(Employee employee)
        {
            this.Email = employee.Email;
            this.Id = (uint)employee.Id;
            this.Name = employee.Name;
            this.Password = employee.Password;
            this.StartWorkingHours = (uint)employee.WorkingHours.StartingHour.Hours;
            this.EndWorkingHours = (uint)employee.WorkingHours.EndingHour.Hours;
            this.Surname = employee.Surname;
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
