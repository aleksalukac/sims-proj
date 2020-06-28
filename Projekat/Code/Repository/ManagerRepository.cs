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
        private const string MANAGER_FILE = @"..\..\Data\ManagerData.txt";

        public ManagerRepository()
        {
            if (!File.Exists(MANAGER_FILE))
            {
                using (StreamWriter sw = File.CreateText(MANAGER_FILE))
                {
                    sw.WriteLine("{}");
                }
            }
        }

        public  Manager Update(Manager manager)
        {
            if(Get().Id != manager.Id)
            {
                return null;
            }

            string managerSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(manager);

            System.IO.File.WriteAllText(MANAGER_FILE, managerSerialized);

            return Get();
        }

        public Manager Get(int id)
        {
            if (this.Get().Id == id)
                return this.Get();
            return null;
        }

        public  Manager Get()
        {
            string managerSerialized = System.IO.File.ReadAllText(MANAGER_FILE); 

            Manager manager = Newtonsoft.Json.JsonConvert.DeserializeObject<Manager>(managerSerialized);

            return manager;
        }

        public  Manager Add(Manager manager)
        {

            if (!File.Exists(MANAGER_FILE) || Get() == null)
            {
                string managerSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(manager);

                System.IO.File.WriteAllText(MANAGER_FILE, managerSerialized);
            }

            return Get();
        }
    }
}