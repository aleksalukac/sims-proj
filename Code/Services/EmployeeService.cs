// File:    EmployeeService.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:02:00 PM
// Purpose: Definition of Class EmployeeService

using Model; using System; using System.Collections.Generic;

namespace Services
{
   public class EmployeeService
   {
      public Secretary EditProfile(Model.Employee employee)
      {
         throw new NotImplementedException();
      }
      
      public System.Collections.Generic.List<UserService> userService;
      
      /// <summary>
      /// Property for collection of UserService
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<UserService> UserService
      {
         get
         {
            if (userService == null)
               userService = new System.Collections.Generic.List<UserService>();
            return userService;
         }
         set
         {
            RemoveAllUserService();
            if (value != null)
            {
               foreach (UserService oUserService in value)
                  AddUserService(oUserService);
            }
         }
      }
      
      /// <summary>
      /// Add a new UserService in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddUserService(UserService newUserService)
      {
         if (newUserService == null)
            return;
         if (this.userService == null)
            this.userService = new System.Collections.Generic.List<UserService>();
         if (!this.userService.Contains(newUserService))
            this.userService.Add(newUserService);
      }
      
      /// <summary>
      /// Remove an existing UserService from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveUserService(UserService oldUserService)
      {
         if (oldUserService == null)
            return;
         if (this.userService != null)
            if (this.userService.Contains(oldUserService))
               this.userService.Remove(oldUserService);
      }
      
      /// <summary>
      /// Remove all instances of UserService from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllUserService()
      {
         if (userService != null)
            userService.Clear();
      }
      public Repository.DoctorRepository doctorRepository;
      public Repository.ManagerRepository managerRepository;
      public Repository.SecretaryRepository secretaryRepository;
   
   }
}