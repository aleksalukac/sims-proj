using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    class RandomData
    {
        static Random rnd = new Random();

        public static RoomView GetRandomRoom()
        {
            RoomView room = new RoomView();
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

                    foreach(var value in values)
                    {
                        specs.Add(value);
                    }
                }

                return specs[rnd.Next() % specs.Count];
            }
        }

        internal static DrugView GetRandomDrug()
        {
            using (var reader = new StreamReader(@"../../Data/RandomDrugNames.txt"))
            {
                List<string> listName = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listName.Add(values[0]);
                }

                DrugView drug = new DrugView();
                drug.Name = listName[rnd.Next() % listName.Count];
                drug.Approved = true;
                drug.Count = rnd.Next() % 300;
                return drug;
            }
        }

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
