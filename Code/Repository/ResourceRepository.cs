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
        public static Resource Remove(int id)
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

        public static Resource Update(Resource resource)
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

        public static Resource Add(Resource resource)
        {
            List<Resource> resources = GetAll();
            resources.Add(resource);
            WriteAll(resources);

            return resource;
        }

        public static Resource Get(int id)
        {
            List<Resource> resources = GetAll();

            foreach (Resource resource in resources)
            {
                if (resource.Id == id)
                    return resource;
            }

            return null;

        }

        public static void WriteAll(List<Resource> resources)
        {
            string resourcesSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(resources);

            System.IO.File.WriteAllText(@"..\..\Data\ResourceData.txt", resourcesSerialized);
        }

        public static List<Resource> GetAll()
        {
            string resourcesSerialized = System.IO.File.ReadAllText(@"..\..\Data\ResourceData.txt");

            List<Resource> resources = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Resource>>(resourcesSerialized);

            return resources;
        }


    }
}