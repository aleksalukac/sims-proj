// File:    User.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class User

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class User : GuestUser
   {
        public User()
        {

        }

        public string Email { get; set; }
        public string Password { get; set; }

        public List<int> Notification { get; set; }
        public List<int> TextContent { get; set; }
   
   }
}