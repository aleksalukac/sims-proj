// File:    ResourceController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:40:30 PM
// Purpose: Definition of Class ResourceController

using Model; using System; using System.Collections.Generic;

namespace Controllers
{
   public class ResourceController
   {
      public List<Resource> GetResourceByType()
      {
         throw new NotImplementedException();
      }
      
      public Resource ChangeResourceRoom(Resource resource, Room room)
      {
         throw new NotImplementedException();
      }
      
      public Services.ResourceService resourceService;
   
   }
}