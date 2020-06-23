// File:    Employee.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Employee

using System;

namespace Model
{
   public class Employee : User
   {
      public WorkingHours workingHours;
      public Vacation vacation;
   
   }
}