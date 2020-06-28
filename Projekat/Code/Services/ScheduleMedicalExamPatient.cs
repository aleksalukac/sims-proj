// File:    ScheduleMedicalExamPatient.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 9:16:05 PM
// Purpose: Definition of Class ScheduleMedicalExamPatient

using Model; using System; using System.Collections.Generic;

namespace Services
{
   public abstract class ScheduleMedicalExamPatient
   {
      public abstract MedicalExam ScheduleAppointment();
   
   }
}