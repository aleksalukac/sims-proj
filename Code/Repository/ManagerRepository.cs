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
        public  Manager Update(Manager manager)
        {
            if(Get().Id != manager.Id)
            {
                return null;
            }

            string managerSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(manager);

            System.IO.File.WriteAllText(@"..\..\Data\ManagerData.txt", managerSerialized);

            return Get();
        }
      
        public  Manager Get()
        {
            string managerSerialized = System.IO.File.ReadAllText(@"..\..\Data\ManagerData.txt"); 

            Manager manager = Newtonsoft.Json.JsonConvert.DeserializeObject<Manager>(managerSerialized);

            return manager;
        }

        public  Manager Add(Manager manager)
        {

            if (!File.Exists(@"..\..\Data\ManagerData.txt") || Get() == null)
            {
                string managerSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(manager);

                System.IO.File.WriteAllText(@"..\..\Data\ManagerData.txt", managerSerialized);
            }

            return Get();
        }
    }
}