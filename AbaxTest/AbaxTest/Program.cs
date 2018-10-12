namespace AbaxTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("NF12345", 147, 200, "Green", VehicleType.Car);
            car.Print();
            var car2 = new Car("NF54321", 150, 195, "Blue", VehicleType.Car);
            car2.Print();
            car.Drive();
            car2.Drive();
            car.Compare(car2, "Car 1 & Car 2 ");

            var plane1 = new Jetplane("LN1234", 1000, 30, 2, 10, VehicleType.Jetplane);
            plane1.Print();
            plane1.StartPlane();

            var boat = new Boat("ABC123", 100, 30, 500);
            boat.Print();
        }
    }
}
