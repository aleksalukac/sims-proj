// File:    Doctor.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Doctor

using System;

namespace Model
{
   public class Doctor : Employee
   {
      public SpecialisationType specialisationType;
      public MedicalExam[] medicalExam;
      public DoctorReview[] doctorReview;
   
   }
}