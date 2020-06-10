using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    public class ManagerView : EmployeeView
    {
        public static ManagerView Manager = new ManagerView();

        public string Password { get; set; }

        private ManagerView() : base()
        {
            
        }

        public static void saveManager()
        {
            var jsonManager = Newtonsoft.Json.JsonConvert.SerializeObject(Manager);
            System.IO.File.WriteAllText(@"C:\Users\Aleksa\source\repos\Hospital\Hospital\Data\UserData.txt", jsonManager);
        }

        public static void resetPassword()
        {
            Manager.Password = Crypt.Encrypt("default");
        }

        public static ManagerView getInstance()
        {
            if(String.IsNullOrEmpty(Manager.Email))
            {
                var newManager = Newtonsoft.Json.JsonConvert.DeserializeObject<ManagerView>(System.IO.File.ReadAllText(@"C:\Users\Aleksa\source\repos\Hospital\Hospital\Data\UserData.txt"));
                Manager.Password = newManager.Password;
                Manager.Name = newManager.Name;
                Manager.Surname = newManager.Surname;
                Manager.OnVacation = newManager.OnVacation;
                Manager.Username = newManager.Username;
                Manager.Email = newManager.Email;
            }
            return Manager;
        }
    }
}
