namespace _07.MilitaryElite.Models.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        public Corps Corp { get; set; }
    }
}
