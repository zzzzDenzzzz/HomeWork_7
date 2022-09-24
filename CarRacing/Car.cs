using System;

namespace CarRacing
{
    internal abstract class Car : ICarMethod
    {
        public string Name { get; set; }
        public int MinSpeed { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        Random random;

        public Car(int maxSpeed)
        {
            Name = "NoName";
            MinSpeed = CurrentSpeed = 0;
            MaxSpeed = maxSpeed;
            random = new Random();
        }

        public void Drive()
        {
            CurrentSpeed = random.Next(MinSpeed, MaxSpeed);
            Console.WriteLine($"{Name} движется со скоростью {CurrentSpeed} км/ч");
        }

        public void Finish()
        {
            Console.WriteLine($"{Name} финиш");
        }

        public void Start()
        {
            Console.WriteLine($"{Name} на старте");
        }
    }
}
