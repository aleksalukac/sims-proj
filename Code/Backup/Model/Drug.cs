// File:    Drug.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Drug

using System;

namespace Model
{
   public class Drug
   {
      private string name;
      private int id;
      private int count;
      private bool approved;
      
      public System.Collections.Generic.List<Drug> similarDrug;
      
      /// <summary>
      /// Property for collection of Drug
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Drug> SimilarDrug
      {
         get
         {
            if (similarDrug == null)
               similarDrug = new System.Collections.Generic.List<Drug>();
            return similarDrug;
         }
         set
         {
            RemoveAllSimilarDrug();
            if (value != null)
            {
               foreach (Drug oDrug in value)
                  AddSimilarDrug(oDrug);
            }
         }
      }
      
      /// <summary>
      /// Add a new Drug in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddSimilarDrug(Drug newDrug)
      {
         if (newDrug == null)
            return;
         if (this.similarDrug == null)
            this.similarDrug = new System.Collections.Generic.List<Drug>();
         if (!this.similarDrug.Contains(newDrug))
            this.similarDrug.Add(newDrug);
      }
      
      /// <summary>
      /// Remove an existing Drug from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveSimilarDrug(Drug oldDrug)
      {
         if (oldDrug == null)
            return;
         if (this.similarDrug != null)
            if (this.similarDrug.Contains(oldDrug))
               this.similarDrug.Remove(oldDrug);
      }
      
      /// <summary>
      /// Remove all instances of Drug from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllSimilarDrug()
      {
         if (similarDrug != null)
            similarDrug.Clear();
      }
      public Doctor[] approvedByDoctor;
   
   }
}