using CargoShipLoader;

internal class Program
{
    private static void Main(string[] args)
    {

        Ship shippyMcShipFace = new Ship();

        string WelcomeMessage = "Welcome to Cargo Ship. The goal of this game is to load the ship to its maximum capacity by adding motor cycles, cars, trucks and train cars. A cycle takes 3 units of weight. A car takes 5 units. A truck takes 11 units. A train car takes 17 units.";

        Console.WriteLine(WelcomeMessage);

        // While loop runs an infinite number of times until the user gets the game to the winning condition.
        // The condition is when the ship's capacity is equal to the ship's load.
        // Repeat until the player gets the ship loaded to capacity.
        while (shippyMcShipFace.Capacity != shippyMcShipFace.GetShipLoad())
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            // As the loop starts, gives the user a status update.
            // Let's the user know how loaded the ship is and how much capacity it has.
            Console.WriteLine("The ship capacity is " + shippyMcShipFace.Capacity);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The ship has " + shippyMcShipFace.CycleCount + " motorcycles on board");
            Console.WriteLine("The ship has " + shippyMcShipFace.CarCount + " cars on board");
            Console.WriteLine("The ship has " + shippyMcShipFace.TruckCount + " trucks on board");
            Console.WriteLine("The ship has " + shippyMcShipFace.TrainCarCount + " train cars on board");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The ship currently has " + shippyMcShipFace.GetShipLoad() + " total units on board");
            Console.ForegroundColor = ConsoleColor.White;

            // User input
            int x; // Used to capture information from the keyboard.

            // MOTORCYCLES
            Console.WriteLine("How many motor cycles would you like to put on a ship?");
            x = int.Parse(Console.ReadLine());

            shippyMcShipFace.CycleCount = x;

            // CARS
            Console.WriteLine("How many cars would you like to put on a ship?");
            x = int.Parse(Console.ReadLine());

            shippyMcShipFace.CarCount = x;

            // TRUCKS
            Console.WriteLine("How many trucks would you like to put on a ship?");
            x = int.Parse(Console.ReadLine());

            shippyMcShipFace.TruckCount = x;

            // TRUCKS
            Console.WriteLine("How many train cars would you like to put on a ship?");
            x = int.Parse(Console.ReadLine());

            shippyMcShipFace.TrainCarCount = x;

            // CALCULATION
            // Find out how much weight the ship is holding
            Console.WriteLine("The ship now has " + shippyMcShipFace.GetShipLoad() + " total units of weight on board");

            // If greater than 0 then the capacity is greater than the total number of items on the ship.
            if (shippyMcShipFace.OverUnder() > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The ship still has room to spare. Load more items.");
            }

            // If the capacity is less than 0 then the ship is overloaded.
            if (shippyMcShipFace.OverUnder() < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The ship is overloaded. Take some items off!");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        // If we escape the while loop then the ship has been loaded successfully.
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You loaded the ship successfully!");

        Console.ReadLine();
    }
}