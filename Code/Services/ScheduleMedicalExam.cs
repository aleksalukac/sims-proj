// File:    ScheduleMedicalExam.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 9:10:32 PM
// Purpose: Definition of Interface ScheduleMedicalExam

using Model; using System; using System.Collections.Generic;

namespace Services
{
   public interface ScheduleMedicalExam
   {
      MedicalExam ScheduleAppointment();
   
   }
}