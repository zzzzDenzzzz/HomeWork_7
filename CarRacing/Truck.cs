namespace CarRacing
{
    internal class Truck : Car
    {
        public Truck(string name, int maxSpeed) : base(maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }
    }
}
