namespace BorderControl.Models
{
    using Interfaces;
  
    public class Robot : IRobot
    {
        public Robot()
        {
            
        }
        public Robot(string model, string id)
            :this()
        {
            Model = model;
            Id = id;
        }

        public string Model { get; private set; }
        public string Id { get; private set; }

        public bool Checkpoit(string id)
        {
            if (this.Id.EndsWith(id))
            {
                return true;
            }
            return false;
        }
    }
}
