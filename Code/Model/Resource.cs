// File:    Resource.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Resource

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Resource : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\ResourceId.txt";
        public Resource() : base(ID_PATH)
        {

        }

        public ResourceType ResourceType { get; set; }
        public int Room { get; set; }
   
   }
}