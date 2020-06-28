// File:    MedicalExam.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class MedicalExam

using System;

namespace Model
{
   public class MedicalExam
   {
      private string report;
      private DateTime appointmentStart;
      private bool isSurgery;
      private DateTime appointmentEnd;
      
      public Doctor doctor;
      public DoctorReview doctorReview;
      public MedicalRecord medicalRecord;
      public Room room;
      
      /// <summary>
      /// Property for Room
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Room Room
      {
         get
         {
            return room;
         }
         set
         {
            if (this.room == null || !this.room.Equals(value))
            {
               if (this.room != null)
               {
                  Room oldRoom = this.room;
                  this.room = null;
                  oldRoom.RemoveMedicalExam(this);
               }
               if (value != null)
               {
                  this.room = value;
                  this.room.AddMedicalExam(this);
               }
            }
         }
      }
      public GuestUser guestUser;
      public Drug therapyDrug;
      
      /// <summary>
      /// Property for Drug
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Drug TherapyDrug
      {
         get
         {
            return therapyDrug;
         }
         set
         {
            this.therapyDrug = value;
         }
      }
   
   }
}