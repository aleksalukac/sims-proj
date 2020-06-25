// File:    UserController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:37:59 PM
// Purpose: Definition of Class UserController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class UserController
   {
        public Model.User Login(string email, string password)
        {
            return _userService.Login(email, password);
        }

        public User Get(int id)
        {
            return _userService.Get(id);
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
      
        private UserService _userService;

        public UserController(UserService userService1)
        {
            this._userService = userService1;
        }

        public User GetLoggedUser()
        {
            return _userService.GetLoggedUser();
        }

        public User Update(User user)
        {
            return _userService.Update(user);
        }
    }
}