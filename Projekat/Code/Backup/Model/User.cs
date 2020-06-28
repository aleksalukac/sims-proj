// File:    User.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class User

using System;

namespace Model
{
   public class User : GuestUser
   {
      private string email;
      private string password;
      private int id;
      
      public Notification[] notification;
      public TextContent[] textContent;
   
   }
}