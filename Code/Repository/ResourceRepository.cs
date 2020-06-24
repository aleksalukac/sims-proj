// File:    ResourceRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:03:15 AM
// Purpose: Definition of Class ResourceRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class ResourceRepository
    {
        private const string RESOURCE_FILE = @"..\..\Data\ResourceData.txt";
        public  Resource Remove(int id)
        {
            List<Resource> resources = GetAll();

            Resource resourceToRemove = resources.SingleOrDefault(r => r.Id == id);

            if (resourceToRemove != null)
            {
                resources.Remove(resourceToRemove);
                WriteAll(resources);
            }

            return resourceToRemove;
        }

        public  Resource Update(Resource resource)
        {

            List<Resource> resources = GetAll();

            for (int i = 0; i < resources.Count; i++)
            {
                if (resources[i].Id == resource.Id)
                {
                    resources[i] = resource;
                    break;
                }
            }

            WriteAll(resources);

            return resource;
        }

        public  Resource Add(Resource resource)
        {
            if (Get(resource.Id) == null)
            {
                List<Resource> resources = GetAll();
                resources.Add(resource);
                WriteAll(resources);

                return resource;
            }
            return null;
        }

        public  Resource Get(int id)
        {
            List<Resource> resources = GetAll();

            foreach (Resource resource in resources)
            {
                if (resource.Id == id)
                    return resource;
            }

            return null;

        }

        public  void WriteAll(List<Resource> resources)
        {
            string resourcesSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(resources);

            System.IO.File.WriteAllText(RESOURCE_FILE, resourcesSerialized);
        }

        public  List<Resource> GetAll()
        {
            string resourcesSerialized = System.IO.File.ReadAllText(RESOURCE_FILE);

            List<Resource> resources = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Resource>>(resourcesSerialized);

            return resources;
        }


    }
}