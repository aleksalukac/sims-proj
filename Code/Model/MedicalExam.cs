// File:    MedicalExam.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class MedicalExam

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
       public class MedicalExam : BaseModel
       {
            private const string ID_PATH = @"..\..\Data\MedicalExamId.txt";
            public MedicalExam() : base(ID_PATH)
            {
                this.IsGuestUser = false;
            }

            public string Report { get; set; }
            public DateTime AppointmentStart { get; set; }

            public const int appointmentDurationHours = 1;
            
            public bool IsSurgery { get; set; }

            public int Doctor { get; set; }
            public DoctorReview DoctorReview { get; set; }
            public int MedicalRecord { get; set; }
            public int Room { get; set; }
      
            public int Patient { get; set; }
            public bool IsGuestUser { get; set; }
            public int TherapyDrug { get; set; }  
       }
}