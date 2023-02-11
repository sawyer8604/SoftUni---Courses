namespace BorderControl.Models.Interfaces
{
    public interface IRobot
    {
        public string Model { get; }       
        public string Id { get; }
        public bool Checkpoit(string id);
    }
}
