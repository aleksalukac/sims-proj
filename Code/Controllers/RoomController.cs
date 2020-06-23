// File:    RoomController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:40:30 PM
// Purpose: Definition of Class RoomController

using Model; using System; using System.Collections.Generic;

namespace Controllers
{
   public class RoomController
   {
      public List<Room> GetAllRoom()
      {
         throw new NotImplementedException();
      }
      
      public Room SetRoomRenovation(DateTime start, DateTime finish)
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetFreeRoom(DateTime dateTime)
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetOccupiedRoom(DateTime dateTime)
      {
         throw new NotImplementedException();
      }
      
      public Services.RoomService roomService;
   
   }
}