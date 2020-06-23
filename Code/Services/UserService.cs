// File:    UserService.cs
// Author:  Aleksa
// Created: Tuesday, May 26, 2020 7:59:18 PM
// Purpose: Definition of Class UserService

using Model; using System; using System.Collections.Generic;

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
      
      public TextContent CreateFeedback(Model.User user, TextContent feedback)
      {
         throw new NotImplementedException();
      }
      
      public TextContent CreateQuestion(Model.User user, TextContent question)
      {
         throw new NotImplementedException();
      }
   
   }
}