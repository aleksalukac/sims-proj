// File:    Employee.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Employee

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Employee : User
   {
        public Employee()
        {
            this.WorkingHours = new WorkingHours(8, 16);
            this.Vacation = new Vacation();
        }

        public Employee(Employee employee)
        {
            this.WorkingHours = employee.WorkingHours;
            this.Vacation = employee.Vacation;
            this.Name = employee.Name;
            this.Notification = employee.Notification;
            this.Password = employee.Password;
            this.Surname = employee.Surname;
            this.TextContent = employee.TextContent;
            this.DateOfBirth = employee.DateOfBirth;
            this.Email = employee.Email;
        }

        public WorkingHours WorkingHours { get; set; }
        public Vacation Vacation { get; set; }
   
   }
}