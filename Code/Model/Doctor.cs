// File:    Doctor.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Doctor

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Doctor : Employee
   {
        public Doctor()
        {
            this.specialisationType = new SpecialisationType();
            medicalExam = new List<int>();
            drugsToApprove = new List<int>();
        }

        public Doctor(Employee employee) : base(employee)
        {
            this.specialisationType = new SpecialisationType();
            medicalExam = new List<int>();
            drugsToApprove = new List<int>();
        }

        public SpecialisationType specialisationType;
        public List<int> medicalExam;
        public List<int> drugsToApprove;
   
   }
}