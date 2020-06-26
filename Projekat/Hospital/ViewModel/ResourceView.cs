using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.ViewModel
{
    public class ResourceView
    {
        public static int idCount = 1;

        public int Id { get; set; }
        public string Type { get; set; }

        public int RoomId { get; set; }

        public ResourceView()
        {
            
        }

        public ResourceView(Resource resource)
        {
            this.Id = resource.Id;
            this.Type = resource.ResourceType.Name;
            this.RoomId = resource.Room;
        }

        public Resource Convert()
        {
            Resource resource = new Resource();
            resource.Id = this.Id;
            resource.ResourceType.Name = this.Type;
            resource.Room = this.RoomId;

            return resource;
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
