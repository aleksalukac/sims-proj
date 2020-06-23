// File:    Room.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Room

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Room : BaseModel
   {
        private const string ID_PATH = @"../../RoomId.txt";
        public Room() : base(ID_PATH)
        {

        }

        public RoomType RoomType { get; set; }

        public string Name { get; set; }

        public System.Collections.Generic.List<int> Patient { get; set; }
        public System.Collections.Generic.List<int> MedicalExam { get; set; }
        public System.Collections.Generic.List<int> Renovation { get; set; }
        public List<int> Resource { get; set; }

    }
}