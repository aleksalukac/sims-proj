// File:    RoomRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:00:50 AM
// Purpose: Definition of Class RoomRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class RoomRepository
   {
      public static Room RemoveRoom(int id)
      {
            List<Room> rooms = GetAllRoom();

            Room roomToRemove = rooms.SingleOrDefault(r => r.id == id);

            if(roomToRemove != null)
            {
                rooms.Remove(roomToRemove);
                WriteAllRoom(rooms);
            }

            return roomToRemove;
      }
      
      public static Room SetRoom(Room room)
      {
            List<Room> rooms = GetAllRoom();

            for(int i = 0; i < rooms.Count; i++)
            {
                if(rooms[i].id == room.id)
                {
                    rooms[i] = room;
                    break;
                }
            }

            WriteAllRoom(rooms);

            return room;
      }
      
      public static Room AddRoom(Room room)
      {
            List<Room> rooms = GetAllRoom();
            rooms.Add(room);
            WriteAllRoom(rooms);

            return room;
      }
      
      public static Room GetRoom(int id)
      {
            List<Room> rooms = GetAllRoom();

            foreach(Room room in rooms)
            {
                if (room.id == id)
                    return room;
            }

            return null;
      }

      public static void WriteAllRoom(List<Room> rooms)
      {
            string roomsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(rooms);

            System.IO.File.WriteAllText(@"..\..\Data\RoomData.txt", roomsSerialized);
      }
      
      public static List<Room> GetAllRoom()
      {
            string roomsSerialized = System.IO.File.ReadAllText(@"..\..\Data\RoomData.txt");

            List<Room> rooms = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Room>>(roomsSerialized);

            return rooms;
      }

    }
}