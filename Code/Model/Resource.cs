// File:    Resource.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Resource

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Resource
   {
      public int id;
      private int type;
      
      public ResourceType resourceType;
      public Room room;
   
   }
}