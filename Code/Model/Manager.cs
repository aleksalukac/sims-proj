// File:    Manager.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Manager

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Manager : Employee
   {
        public Manager()
        {
            Report = new List<int>();
        }

        public Manager(Employee employee) : base(employee)
        {
            Report = new List<int>();
        }

        public List<int> Report { get; set; }
   }
}