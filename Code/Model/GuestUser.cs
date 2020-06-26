// File:    GuestUser.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class GuestUser

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class GuestUser : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\UserId.txt";

        public GuestUser() : base(ID_PATH) 
        {

        }

        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
   
   }
}