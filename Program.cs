using CargoShipLoader;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Make a new copy/object of the ship.
        Ship myCargoShip = new Ship();
        myCargoShip.TrainCarCount = 8;
        myCargoShip.CycleCount = 3;

        // Uses ToString method to print out something about the ship details.
        Console.WriteLine("This ship is " + myCargoShip.ToString());

        Console.ReadLine();
    }
}