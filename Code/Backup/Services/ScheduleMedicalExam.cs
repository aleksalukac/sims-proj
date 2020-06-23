// File:    ScheduleMedicalExam.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 9:10:32 PM
// Purpose: Definition of Interface ScheduleMedicalExam

using System;

namespace Services
{
   public interface ScheduleMedicalExam
   {
      MedicalExam ScheduleAppointment();
   
   }
}