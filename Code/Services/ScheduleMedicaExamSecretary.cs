// File:    ScheduleMedicaExamSecretary.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 9:14:13 PM
// Purpose: Definition of Class ScheduleMedicaExamSecretary

using Model; using System; using System.Collections.Generic;

namespace Services
{
   public abstract class ScheduleMedicaExamSecretary
   {
      public abstract MedicalExam ScheduleAppointment();
   
   }
}