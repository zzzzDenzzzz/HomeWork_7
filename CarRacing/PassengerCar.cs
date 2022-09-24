namespace CarRacing
{
    internal class PassengerCar : Car
    {
        public PassengerCar(string name, int maxSpeed) : base(maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }
    }
}
