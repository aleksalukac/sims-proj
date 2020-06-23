// File:    RoomService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:25:14 PM
// Purpose: Definition of Class RoomService

using System;

namespace Services
{
   public class RoomService
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
      
      public Repository.RoomRepository roomRepository;
   
   }
}