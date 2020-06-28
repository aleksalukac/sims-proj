// File:    ScheduleMedicaExamGuestUser.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 9:16:00 PM
// Purpose: Definition of Class ScheduleMedicaExamGuestUser

using Model; using System; using System.Collections.Generic;

namespace Services
{
   public abstract class ScheduleMedicaExamGuestUser
   {
      public abstract MedicalExam ScheduleAppointment();
   
   }
}