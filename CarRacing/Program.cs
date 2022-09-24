namespace CarRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sportCar = new SportCar("SportCar", 320);
            var passengerCar = new PassengerCar("PassengerCar", 220);
            var truck = new Truck("Truck", 180);
            var bus = new Bus("Bus", 150);

            var game = new Game(99);

            game.onStart += sportCar.Start;
            game.onStart += passengerCar.Start;
            game.onStart += truck.Start;
            game.onStart += bus.Start;

            game.onDrive += sportCar.Drive;
            game.onDrive += passengerCar.Drive;
            game.onDrive += truck.Drive;
            game.onDrive += bus.Drive;

            game.onFinish += sportCar.Finish;
            game.onFinish += passengerCar.Finish;
            game.onFinish += truck.Finish;
            game.onFinish += bus.Finish;

            game.Start();
        }
    }
}
