// File:    ResourceService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 3:21:08 PM
// Purpose: Definition of Class ResourceService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class ResourceService
   {
      public List<Resource> GetResourceByType()
      {
         throw new NotImplementedException();
      }
      
      public Resource ChangeResourceRoom(Resource resource, Room room)
      {
         throw new NotImplementedException();
      }
      
        private ResourceRepository _resourceRepository;

        public ResourceService(ResourceRepository resourceRepository1)
        {
            this._resourceRepository = resourceRepository1;
        }
    }
}