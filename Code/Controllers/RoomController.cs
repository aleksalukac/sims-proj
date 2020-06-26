// File:    RoomController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:40:30 PM
// Purpose: Definition of Class RoomController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class RoomController
   {
        public List<Room> GetAllRoom()
        {
            throw new NotImplementedException();
        }
      
        public List<Room> GetFreeRooms(DateTime examDateTime, RoomType roomType)
        {
            return _roomService.GetFreeRooms(examDateTime, roomType);
        }

        public Room SetRoomRenovation(DateTime start, DateTime finish)
        {
            throw new NotImplementedException();
        }
      
        public List<Room> GetFreeRoom(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Renovation GetFutureRenovation(int id)
        {
            return _roomService.GetFutureRenovation(id);
        }

        public List<Room> GetOccupiedRoom(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
      
        private RoomService _roomService;

        public RoomController(RoomService roomService1)
        {
            this._roomService = roomService1;
        }

        public List<Room> GetAll()
        {
            return _roomService.GetAll();
        }

        public Room Update(Room room)
        {
            return _roomService.Update(room);
        }

        public Room Add(Room room)
        {
            return _roomService.Add(room);
        }

        public Room Remove(int id)
        {
            return _roomService.Remove(id);
        }

        public Room Merge(int id1, int id2)
        {
            return _roomService.Merge(id1, id2);
        }

        public bool CanRenovate(int id, DateTime renovationDateTime)
        {
            return _roomService.CanRenovate(id, renovationDateTime);
        }

        public Renovation AddRenovation(Renovation renovation)
        {
            return _roomService.AddRenovation(renovation);
        }

        public Room Get(int id)
        {
            return _roomService.Get(id);
        }
    }
}