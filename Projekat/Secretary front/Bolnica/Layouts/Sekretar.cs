using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Layouts
{
   public  class Sekretar : Employee
    {
        public static Sekretar sekretar = new Sekretar();

        public string Password { get; set; }

        private Sekretar() : base()
        {

        }

        public static void saveSekretar()
        {
            var jsonManager = Newtonsoft.Json.JsonConvert.SerializeObject(sekretar);
            System.IO.File.WriteAllText(@"..\..\Data\UserData.txt", jsonManager);
        }

        public static void resetPassword()
        {
            sekretar.Password = Crypt.Encrypt("default");
        }

        public static  Sekretar getInstance()
        {
            if (String.IsNullOrEmpty(sekretar.Email))
            {
                var sekretarNovi = Newtonsoft.Json.JsonConvert.DeserializeObject<Sekretar>(System.IO.File.ReadAllText(@"..\..\Data\UserData.txt"));
                sekretar.Password = sekretarNovi.Password;
                sekretar.Name = sekretarNovi.Name;
                sekretar.Surname = sekretarNovi.Surname;
                sekretar.OnVacation = sekretarNovi.OnVacation;
                sekretar.Username = sekretarNovi.Username;
                sekretar.Email = sekretarNovi.Email;
            }
            return sekretar;
        }
    }
}
