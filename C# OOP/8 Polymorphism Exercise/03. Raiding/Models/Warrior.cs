namespace Raiding.Models
{
    public class Warrior : Rogue
    {
        public Warrior(string name)
            : base(name)
        {
        }

        public override int Power => 100;
    }
}
