namespace Bolnica.Layouts
{
    public class Lekar:Employee
    {
        public string Specialisation { get; set; }

        public bool Contains(string str)
        {
            return Specialisation.ToUpper().Contains(str) || base.Contains(str);
        }

        public override string ToString()
        {
            return Name + " " + Surname + " | " + Id.ToString();
        }

        public Lekar(bool random = false) : base(random)
        {
            if (random)
                this.Specialisation = RandomData.GetRandomSpecialization();
        }
    }
}