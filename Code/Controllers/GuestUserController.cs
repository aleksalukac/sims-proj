// File:    GuestUserController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:43:59 PM
// Purpose: Definition of Class GuestUserController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class GuestUserController
   {
      public User Register(User newUser)
      {
         throw new NotImplementedException();
      }
      
        private GuestUserService _guestUserService;

        public GuestUserController(GuestUserService guestUserService1)
        {
            this._guestUserService = guestUserService1;
          }
        public GuestUser Add(GuestUser guestUser) {
            return _guestUserService.Add(guestUser);
        }
    }
}