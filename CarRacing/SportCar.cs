namespace CarRacing
{
    internal class SportCar : Car
    {
        public SportCar(string name, int maxSpeed) : base(maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }
    }
}
