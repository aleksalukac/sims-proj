// File:    Doctor.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Doctor

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Doctor : Employee
   {
      public SpecialisationType specialisationType;
      public List<int> medicalExam;
   
   }
}