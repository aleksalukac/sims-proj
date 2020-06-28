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
      

        public User GetByEmail(string email)
        {
            return _userService.GetByEmail(email);
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