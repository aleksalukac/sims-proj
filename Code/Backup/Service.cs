// File:    Service.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:42:08 PM
// Purpose: Definition of Class Service

using System;

public class Service
{
   public System.Collections.Generic.List<Repository> repository;
   
   /// <summary>
   /// Property for collection of Repository
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Repository> Repository
   {
      get
      {
         if (repository == null)
            repository = new System.Collections.Generic.List<Repository>();
         return repository;
      }
      set
      {
         RemoveAllRepository();
         if (value != null)
         {
            foreach (Repository oRepository in value)
               AddRepository(oRepository);
         }
      }
   }
   
   /// <summary>
   /// Add a new Repository in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddRepository(Repository newRepository)
   {
      if (newRepository == null)
         return;
      if (this.repository == null)
         this.repository = new System.Collections.Generic.List<Repository>();
      if (!this.repository.Contains(newRepository))
         this.repository.Add(newRepository);
   }
   
   /// <summary>
   /// Remove an existing Repository from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveRepository(Repository oldRepository)
   {
      if (oldRepository == null)
         return;
      if (this.repository != null)
         if (this.repository.Contains(oldRepository))
            this.repository.Remove(oldRepository);
   }
   
   /// <summary>
   /// Remove all instances of Repository from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllRepository()
   {
      if (repository != null)
         repository.Clear();
   }

}