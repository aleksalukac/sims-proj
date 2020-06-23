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
      public static Resource RemoveResource(int id)
      {
            List<Resource> resources = GetAllResource();

            Resource resourceToRemove = resources.SingleOrDefault(r => r.id == id);

            if (resourceToRemove != null)
            {
                resources.Remove(resourceToRemove);
                WriteAllResource(resources);
            }

            return resourceToRemove;
        }
      
      public static Resource SetResource(Resource resource)
      {

            List<Resource> resources = GetAllResource();

            for (int i = 0; i < resources.Count; i++)
            {
                if (resources[i].id == resource.id)
                {
                    resources[i] = resource;
                    break;
                }
            }

            WriteAllResource(resources);

            return resource;
        }
      
      public static Resource AddResource(Resource resource)
      {
            List<Resource> resources = GetAllResource();
            resources.Add(resource);
            WriteAllResource(resources);

            return resource;
        }
      
      public static Resource GetResource(int id)
      {
            List<Resource> resources= GetAllResource();

            foreach (Resource resource in resources)
            {
                if (resource.id == id)
                    return resource;
            }

            return null;

        }

        public static void WriteAllResource(List<Resource> resources)
        {
            string resourcesSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(resources);

            System.IO.File.WriteAllText(@"..\..\Data\ResourceData.txt", resourcesSerialized);
        }

        public static List<Resource> GetAllResource()
      {
            string resourcesSerialized = System.IO.File.ReadAllText(@"..\..\Data\ResourceData.txt");

            List<Resource> resources = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Resource>>(resourcesSerialized);

            return resources;
        }
   
   }
}