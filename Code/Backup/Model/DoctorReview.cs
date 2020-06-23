// File:    DoctorReview.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class DoctorReview

using System;

namespace Model
{
   public class DoctorReview
   {
      private string text;
      private uint rating;
      
      public MedicalExam medicalExam;
      public Doctor doctor;
   
   }
}