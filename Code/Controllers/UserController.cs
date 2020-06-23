// File:    UserController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:37:59 PM
// Purpose: Definition of Class UserController

using Model; using System; using System.Collections.Generic;

namespace Controllers
{
   public class UserController
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
      
      public Services.UserService userService;
   
   }
}