// File:    GuestUserService.cs
// Author:  Aleksa
// Created: Tuesday, May 26, 2020 7:57:27 PM
// Purpose: Definition of Class GuestUserService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class GuestUserService
   {
        private GuestUserRepository _guestUserRepository;

        public GuestUserService( GuestUserRepository guestUserRepository)
        {
            this._guestUserRepository = guestUserRepository;
        }
        public GuestUser Add(GuestUser guestUser) {
            return _guestUserRepository.Add(guestUser);
        }
    }
}