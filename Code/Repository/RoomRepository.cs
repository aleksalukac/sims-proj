// File:    RoomRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:00:50 AM
// Purpose: Definition of Class RoomRepository

using Model; using System; using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class RoomRepository
    {
        private const string ROOM_FILE = @"..\..\Data\RoomData.txt";

        public RoomRepository()
        {
            if (!File.Exists(ROOM_FILE))
            {
                using (StreamWriter sw = File.CreateText(ROOM_FILE))
                {
                    sw.WriteLine("[]");
                }
            }
        }

        public  Room Remove(int id)
      {
            List<Room> rooms = GetAll();

            Room roomToRemove = rooms.SingleOrDefault(r => r.Id == id);

            if(roomToRemove != null)
            {
                rooms.Remove(roomToRemove);
                WriteAll(rooms);
            }

            return roomToRemove;
      }
      
      public  Room Update(Room room)
      {
            List<Room> rooms = GetAll();

            for(int i = 0; i < rooms.Count; i++)
            {
                if(rooms[i].Id == room.Id)
                {
                    rooms[i] = room;
                    break;
                }
            }

            WriteAll(rooms);

            return room;
      }
      
      public  Room Add(Room room)
      {
            if (Get(room.Id) == null)
            {
                List<Room> rooms = GetAll();
                rooms.Add(room);
                WriteAll(rooms);

                return room;
            }
            return null;
      }
      
      public  Room Get(int id)
      {
            List<Room> rooms = GetAll();

            foreach(Room room in rooms)
            {
                if (room.Id == id)
                    return room;
            }

            return null;
      }

      public  void WriteAll(List<Room> rooms)
      {
            string roomsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(rooms);

            System.IO.File.WriteAllText(ROOM_FILE, roomsSerialized);
      }
      
      public  List<Room> GetAll()
      {
            string roomsSerialized = System.IO.File.ReadAllText(ROOM_FILE); //roomPath

            List<Room> rooms = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Room>>(roomsSerialized);

            return rooms;
      }

    }
}