// File:    UserController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:37:59 PM
// Purpose: Definition of Class UserController

using System;

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
      
      public Feedback CreateFeedback(Model.User user, Feedback feedback)
      {
         throw new NotImplementedException();
      }
      
      public Question CreateQuestion(Model.User user, Question question)
      {
         throw new NotImplementedException();
      }
      
      public Services.UserService userService;
   
   }
}