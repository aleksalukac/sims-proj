// File:    Room.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Room

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Room
   {
      public int id;
      public RoomType roomType;
      
      public System.Collections.Generic.List<Patient> patient;
      
      /// <summary>
      /// Property for collection of Patient
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Patient> Patient
      {
         get
         {
            if (patient == null)
               patient = new System.Collections.Generic.List<Patient>();
            return patient;
         }
         set
         {
            RemoveAllPatient();
            if (value != null)
            {
               foreach (Patient oPatient in value)
                  AddPatient(oPatient);
            }
         }
      }
      
      /// <summary>
      /// Add a new Patient in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPatient(Patient newPatient)
      {
         if (newPatient == null)
            return;
         if (this.patient == null)
            this.patient = new System.Collections.Generic.List<Patient>();
         if (!this.patient.Contains(newPatient))
         {
            this.patient.Add(newPatient);
            newPatient.Room = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Patient from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePatient(Patient oldPatient)
      {
         if (oldPatient == null)
            return;
         if (this.patient != null)
            if (this.patient.Contains(oldPatient))
            {
               this.patient.Remove(oldPatient);
               oldPatient.Room = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Patient from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPatient()
      {
         if (patient != null)
         {
            System.Collections.ArrayList tmpPatient = new System.Collections.ArrayList();
            foreach (Patient oldPatient in patient)
               tmpPatient.Add(oldPatient);
            patient.Clear();
            foreach (Patient oldPatient in tmpPatient)
               oldPatient.Room = null;
            tmpPatient.Clear();
         }
      }
      public System.Collections.Generic.List<MedicalExam> medicalExam;
      
      /// <summary>
      /// Property for collection of MedicalExam
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<MedicalExam> MedicalExam
      {
         get
         {
            if (medicalExam == null)
               medicalExam = new System.Collections.Generic.List<MedicalExam>();
            return medicalExam;
         }
         set
         {
            RemoveAllMedicalExam();
            if (value != null)
            {
               foreach (MedicalExam oMedicalExam in value)
                  AddMedicalExam(oMedicalExam);
            }
         }
      }
      
      /// <summary>
      /// Add a new MedicalExam in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddMedicalExam(MedicalExam newMedicalExam)
      {
         if (newMedicalExam == null)
            return;
         if (this.medicalExam == null)
            this.medicalExam = new System.Collections.Generic.List<MedicalExam>();
         if (!this.medicalExam.Contains(newMedicalExam))
         {
            this.medicalExam.Add(newMedicalExam);
            newMedicalExam.Room = this;
         }
      }
      
      /// <summary>
      /// Remove an existing MedicalExam from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveMedicalExam(MedicalExam oldMedicalExam)
      {
         if (oldMedicalExam == null)
            return;
         if (this.medicalExam != null)
            if (this.medicalExam.Contains(oldMedicalExam))
            {
               this.medicalExam.Remove(oldMedicalExam);
               oldMedicalExam.Room = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of MedicalExam from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllMedicalExam()
      {
         if (medicalExam != null)
         {
            System.Collections.ArrayList tmpMedicalExam = new System.Collections.ArrayList();
            foreach (MedicalExam oldMedicalExam in medicalExam)
               tmpMedicalExam.Add(oldMedicalExam);
            medicalExam.Clear();
            foreach (MedicalExam oldMedicalExam in tmpMedicalExam)
               oldMedicalExam.Room = null;
            tmpMedicalExam.Clear();
         }
      }
      public System.Collections.Generic.List<Renovation> renovation;
      
      /// <summary>
      /// Property for collection of Renovation
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Renovation> Renovation
      {
         get
         {
            if (renovation == null)
               renovation = new System.Collections.Generic.List<Renovation>();
            return renovation;
         }
         set
         {
            RemoveAllRenovation();
            if (value != null)
            {
               foreach (Renovation oRenovation in value)
                  AddRenovation(oRenovation);
            }
         }
      }
      
      /// <summary>
      /// Add a new Renovation in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddRenovation(Renovation newRenovation)
      {
         if (newRenovation == null)
            return;
         if (this.renovation == null)
            this.renovation = new System.Collections.Generic.List<Renovation>();
         if (!this.renovation.Contains(newRenovation))
            this.renovation.Add(newRenovation);
      }
      
      /// <summary>
      /// Remove an existing Renovation from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveRenovation(Renovation oldRenovation)
      {
         if (oldRenovation == null)
            return;
         if (this.renovation != null)
            if (this.renovation.Contains(oldRenovation))
               this.renovation.Remove(oldRenovation);
      }
      
      /// <summary>
      /// Remove all instances of Renovation from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllRenovation()
      {
         if (renovation != null)
            renovation.Clear();
      }
      public Resource[] resource;
   
   }
}