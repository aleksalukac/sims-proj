// File:    UserService.cs
// Author:  Aleksa
// Created: Tuesday, May 26, 2020 7:59:18 PM
// Purpose: Definition of Class UserService

using System;

namespace Services
{
   public class UserService
   {
      public Model.User Login(string email, string password)
      {
         throw new NotImplementedException();
      }
      
      public Boolean Logout()
      {
         throw new NotImplementedException();
      }
      
      public Boolean ChangePassword(Model.User user, string newPassword)
      {
         throw new NotImplementedException();
      }
      
      public List<Notification> GetNotifications(Model.User user)
      {
         throw new NotImplementedException();
      }
      
      public Feedback CreateFeedback(Model.User user, Feedback feedback)
      {
         throw new NotImplementedException();
      }
      
      public Question CreateQuestion(Model.User user, Question question)
      {
         throw new NotImplementedException();
      }
   
   }
}