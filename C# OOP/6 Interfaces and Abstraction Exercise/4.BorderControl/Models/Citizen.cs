
namespace BorderControl.Models
{
    using Interfaces;    
    
    public class Citizen : ICitizen
    {
        public Citizen()
        {
            
        }
        public Citizen(string name, int age, string id)
            :this()
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public bool Checkpoit(string id)
        {
            if(this.Id.EndsWith(id))
            {
                return true;
            }
            return false;
        }
    }
}
