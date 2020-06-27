// File:    ResourceController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:40:30 PM
// Purpose: Definition of Class ResourceController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class ResourceController
   {
        private ResourceService _resourceService;

        public ResourceController(ResourceService resourceService1)
        {
            this._resourceService = resourceService1;
        }

        public List<Resource> GetAll()
        {
            return _resourceService.GetAll();
        }

        public Resource Update(Resource resource)
        {
            return _resourceService.Update(resource);
        }

        public Resource Add(Resource resource)
        {
            return _resourceService.Add(resource);
        }

        public Resource Get(int id)
        {
            return _resourceService.Get(id);
        }

        public Resource Remove(int id)
        {
            return _resourceService.Remove(id);
        }
    }
}