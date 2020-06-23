// File:    Resource.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Resource

using System;

namespace Model
{
   public class Resource
   {
      private int id;
      private int type;
      
      public ResourceType resourceType;
      public Room room;
   
   }
}