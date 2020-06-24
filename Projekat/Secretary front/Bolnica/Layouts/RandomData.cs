using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Layouts
{
    class RandomData
    {
        static Random rnd = new Random();

        public static Room GetRandomRoom()
        {
            Room room = new Room();
            room.RoomType = ((RoomType)(rnd.Next() % 2)).ToString();

            return room;
        }

        

        public static string GetRandomSpecialization()
        {
            using (var reader = new StreamReader(@"../../Data/RandomSpecialization.txt"))
            {
                List<string> specs = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    foreach (var value in values)
                    {
                        specs.Add(value);
                    }
                }

                return specs[rnd.Next() % specs.Count];
            }
        }

        static int supplyCount = 0;

        

        public static string GetRandomSurname()
        {
            using (var reader = new StreamReader(@"../../Data/RandomNames.txt"))
            {
                List<string> listName = new List<string>();
                List<string> listLastname = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(' ');

                    listName.Add(values[0]);
                    listLastname.Add(values[1]);
                }

                return listLastname[rnd.Next() % listLastname.Count];
            }
        }

        public static string GetRandomName()
        {
            using (var reader = new StreamReader(@"../../Data/RandomNames.txt"))
            {
                List<string> listName = new List<string>();
                List<string> listLastName = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(' ');

                    listName.Add(values[0]);
                    listLastName.Add(values[1]);
                }

                return listName[rnd.Next() % listName.Count];
            }
        }
    }
}
