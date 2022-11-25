using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipLoader
{
    /// <summary>
    /// Ship class.
    /// </summary>
    internal class Ship
    {
        // Constant values
        const int CYCLE_WEIGHT = 3;
        const int CAR_WEIGHT = 5;
        const int TRUCK_WEIGHT = 11;
        const int TRAIN_WEIGHT = 17;

        const int MAX_WEIGHT = 10;

        /// <summary>
        /// Random variable to generate random numbers.
        /// </summary>
        Random random = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="Ship"/> class.
        /// Constructor - called when a new instance of the ship is created.
        /// </summary>
        public Ship()
        {
            this.CycleCount = 0;
            this.CarCount = 0;
            this.TruckCount = 0;
            this.TrainCarCount = 0;

            // Create a random sized ship, using MAX_WEIGHT as the constant value.
            this.Capacity = (this.random.Next(MAX_WEIGHT) * CYCLE_WEIGHT) + (this.random.Next(MAX_WEIGHT) * CAR_WEIGHT) + (this.random.Next(MAX_WEIGHT) * TRUCK_WEIGHT) + (this.random.Next(MAX_WEIGHT) * TRAIN_WEIGHT);
        }

        // Properties for the class

        /// <summary>
        /// Gets or sets capacity of cargo ship.
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Gets or sets the count of motorcycles.
        /// </summary>
        public int CycleCount { get; set; }

        /// <summary>
        /// Gets or sets the count of cars.
        /// </summary>
        public int CarCount { get; set; }

        /// <summary>
        /// Gets or sets the count of trucks.
        /// </summary>
        public int TruckCount { get; set; }

        /// <summary>
        /// Gets or sets hte count of train cars.
        /// </summary>
        public int TrainCarCount { get; set; }

        // Methods (functions)

        /// <summary>
        /// Take the capacity of the ship and subtract how much is loaded on the ship.
        /// </summary>
        /// <returns>Returns a value on how loaded the ship is.</returns>
        public int OverUnder()
        {
            // Capacity is calculated when we create teh ship & the GetShipLoad changes as the user plays the game.
            return this.Capacity - this.GetShipLoad();
        }

        /// <summary>
        /// ToString() method takes some properties and puts them into a string so that you can use it as a message in the app.
        /// </summary>
        /// <returns>Return a label that we're going to show on the ship. Return a string to our program.</returns>
        public override string ToString()
        {
            return "Capacity = " + this.Capacity + ", CurrentLoad = " + this.GetShipLoad();
        }

        /// <summary>
        /// Calculate the amount of space that is occupied by all the trains, cars and motorcycles on cagro ship.
        /// </summary>
        /// <returns>The overall weight of all the vehicles combined with the count of vehicles on the ship.</returns>
        public int GetShipLoad()
        {
            // Calculate the total weight of the cargo on the ship.
            return (this.CycleCount * CYCLE_WEIGHT) + (this.CarCount * CAR_WEIGHT) + (this.TruckCount * TRUCK_WEIGHT) + (this.TrainCarCount * TRAIN_WEIGHT);
        }
    }
}
