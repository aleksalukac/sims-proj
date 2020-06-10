﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    public class ResourceView
    {
        public static int idCount = 1;

        public int Id { get; set; }
        public string Type { get; set; }

        public int RoomId { get; set; }

        public ResourceView()
        {
            Id = idCount++;
        }

        public bool Contains(string str)
        {
            return Type.ToUpper().Contains(str) || RoomId.ToString().Contains(str) || Id.ToString().Contains(str);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
