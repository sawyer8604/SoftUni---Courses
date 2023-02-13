using FoodShortage.Models.Interfaces;

namespace FoodShortage.Models
{
    public class Citizen : IBirthdate, IBuyer
    {
        private int sum = 0;
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
        public int BuyFood(int number)
        {
            return number;
        }
    }
}
