// File:    MedicalRecord.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class MedicalRecord

using System;

namespace Model
{
   public class MedicalRecord
   {
      public Patient patient;
      public MedicalExam[] medicalExam;
      public System.Collections.Generic.List<Drug> therapy;
      
      /// <summary>
      /// Property for collection of Drug
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Drug> Therapy
      {
         get
         {
            if (therapy == null)
               therapy = new System.Collections.Generic.List<Drug>();
            return therapy;
         }
         set
         {
            RemoveAllTherapy();
            if (value != null)
            {
               foreach (Drug oDrug in value)
                  AddTherapy(oDrug);
            }
         }
      }
      
      /// <summary>
      /// Add a new Drug in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddTherapy(Drug newDrug)
      {
         if (newDrug == null)
            return;
         if (this.therapy == null)
            this.therapy = new System.Collections.Generic.List<Drug>();
         if (!this.therapy.Contains(newDrug))
            this.therapy.Add(newDrug);
      }
      
      /// <summary>
      /// Remove an existing Drug from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveTherapy(Drug oldDrug)
      {
         if (oldDrug == null)
            return;
         if (this.therapy != null)
            if (this.therapy.Contains(oldDrug))
               this.therapy.Remove(oldDrug);
      }
      
      /// <summary>
      /// Remove all instances of Drug from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllTherapy()
      {
         if (therapy != null)
            therapy.Clear();
      }
   
   }
}