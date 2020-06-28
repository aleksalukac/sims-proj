// File:    PriorityMedicalExamDTO.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 12:24:05 PM
// Purpose: Definition of Class PriorityMedicalExamDTO

using Model; using System; using System.Collections.Generic;

namespace Services
{
   public class PriorityMedicalExamDTO
   {
      private int patientId;
      private int doctorId;
      private bool isDoctorPriority;
      private DateTime examTime;
   
   }
}