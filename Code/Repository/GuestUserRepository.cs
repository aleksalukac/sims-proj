// File:    GuestUserRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:31:56 AM
// Purpose: Definition of Class GuestUserRepository

using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
    public class GuestUserRepository
    {
        private const string GUEST_USER_FILE = @"..\..\Data\GuestUserData.txt";

        public GuestUserRepository()
        {
            if (!File.Exists(GUEST_USER_FILE))
            {
                using (StreamWriter sw = File.CreateText(GUEST_USER_FILE))
                {
                    sw.WriteLine("[]");
                }
            }
        }

        public GuestUser Update(GuestUser guestUser)
        {
            List<GuestUser> guestUsers = GetAll();

            for (int i = 0; i < guestUsers.Count; i++)
            {
                if (guestUsers[i].Id == guestUser.Id)
                {
                    guestUsers[i] = guestUser;
                    break;
                }
            }

            WriteAll(guestUsers);

            return guestUser;
        }

    
        public GuestUser Get(int id)
        {
            List<GuestUser> guestUsers = GetAll();

            foreach (GuestUser guestUser in guestUsers)
            {
                if (guestUser.Id == id)
                    return guestUser;
            }

            return null;
        }

        public GuestUser Remove(int id)
        {
            List<GuestUser> guestUsers = GetAll();

            GuestUser guestUserToRemove = guestUsers.SingleOrDefault(r => r.Id == id);

            if (guestUserToRemove != null)
            {
                guestUsers.Remove(guestUserToRemove);
                WriteAll(guestUsers);
            }

            return guestUserToRemove;
        }

        public GuestUser Add(GuestUser guestUser)
        {
            if (Get(guestUser.Id) == null)
            {
                List<GuestUser> guestUsers = GetAll();
                guestUsers.Add(guestUser);
                WriteAll(guestUsers);

                return guestUser;
            }
            return null;
        }

        public List<GuestUser> GetAll()
        {
            string guestUsersSerialized = System.IO.File.ReadAllText(GUEST_USER_FILE); //guestUserPath

            List<GuestUser> guestUsers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GuestUser>>(guestUsersSerialized);

            return guestUsers;
        }


        public void WriteAll(List<GuestUser> guestUsers)
        {
            string guestUsersSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(guestUsers);

            System.IO.File.WriteAllText(GUEST_USER_FILE, guestUsersSerialized);
        }

    }
}