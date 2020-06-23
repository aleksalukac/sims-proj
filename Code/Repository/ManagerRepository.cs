// File:    ManagerRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:36:36 AM
// Purpose: Definition of Class ManagerRepository

using Model; using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class ManagerRepository
   {
        public static Manager SetManager(Manager manager)
        {
            if(GetManager().Id != manager.Id)
            {
                return null;
            }

            string managerSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(manager);

            System.IO.File.WriteAllText(@"..\..\Data\ManagerData.txt", managerSerialized);

            return GetManager();
        }
      
        public static Manager GetManager()
        {
            string managerSerialized = System.IO.File.ReadAllText(@"..\..\Data\ManagerData.txt"); //doctorPath

            Manager manager = Newtonsoft.Json.JsonConvert.DeserializeObject<Manager>(managerSerialized);

            return manager;
        }
      
        public static Manager AddManager(Manager manager)
        {
            if(!File.Exists(@"..\..\Data\ManagerData.txt") || GetManager() == null)
            {
                string managerSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(manager);

                System.IO.File.WriteAllText(@"..\..\Data\ManagerData.txt", managerSerialized);
            }

            return GetManager();
        }
    }
}