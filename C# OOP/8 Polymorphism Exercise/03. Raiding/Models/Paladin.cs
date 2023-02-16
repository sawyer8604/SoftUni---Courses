namespace Raiding.Models
{
    public class Paladin : Druid
    {
        public override int Power => 100;
        public Paladin(string name)
            : base(name)
        {
        }
    }
}
