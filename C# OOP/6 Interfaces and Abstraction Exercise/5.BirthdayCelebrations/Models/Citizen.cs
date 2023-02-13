namespace _05.BirthdayCelebrations.Models
{
    using Models.Interfaces;
  
    public class Citizen : IBirthdate
    {   
        public Citizen(string name, int age, string iD, string birthdate)
        {
            Name = name;
            Age = age;
            ID = iD;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string ID { get; private set; }
        public string Birthdate { get; private set; }
    }
}
