// File:    Patient.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Patient

using System;

namespace Model
{
   public class Patient : User
   {
      private string jmbg;
      private int insuranceNumber;
      private string insuranceCarrier;
      private string gender;
      private string address;
      private string phoneNumber;
      
      public System.Collections.Generic.List<Drug> alergy;
      
      /// <summary>
      /// Property for collection of Drug
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Drug> Alergy
      {
         get
         {
            if (alergy == null)
               alergy = new System.Collections.Generic.List<Drug>();
            return alergy;
         }
         set
         {
            RemoveAllAlergy();
            if (value != null)
            {
               foreach (Drug oDrug in value)
                  AddAlergy(oDrug);
            }
         }
      }
      
      /// <summary>
      /// Add a new Drug in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAlergy(Drug newDrug)
      {
         if (newDrug == null)
            return;
         if (this.alergy == null)
            this.alergy = new System.Collections.Generic.List<Drug>();
         if (!this.alergy.Contains(newDrug))
            this.alergy.Add(newDrug);
      }
      
      /// <summary>
      /// Remove an existing Drug from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAlergy(Drug oldDrug)
      {
         if (oldDrug == null)
            return;
         if (this.alergy != null)
            if (this.alergy.Contains(oldDrug))
               this.alergy.Remove(oldDrug);
      }
      
      /// <summary>
      /// Remove all instances of Drug from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAlergy()
      {
         if (alergy != null)
            alergy.Clear();
      }
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
                  oldRoom.RemovePatient(this);
               }
               if (value != null)
               {
                  this.room = value;
                  this.room.AddPatient(this);
               }
            }
         }
      }
   
   }
}