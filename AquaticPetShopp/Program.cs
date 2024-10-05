namespace AquaticPetShop
{
    public class Fish
    {
        public string Species { get; set; }

        public double PricePerFish { get; set; }

        public class FishUtility : Fish
        {
            public void AddFish(string species, double pricePerFish)
            {
                this.Species = species;
                this.PricePerFish = pricePerFish;
            }
            public bool BuyFish()
            {
                if (Species == "Clownfish" || Species == "Goldfish")
                {
                    return true;
                }
                return false;
            }
            public double CalculatePrice(int numberOfFishes)
            {
                double totalPrice = numberOfFishes * PricePerFish;

                if (Species == "Clownfish")
                {
                    totalPrice += 100;
                }
                else if (Species == "GoldFish")
                {
                    totalPrice += 150;
                }
                return totalPrice;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // Create an instance of FishUtility class
                FishUtility fishUtility = new FishUtility();

                // Get the species of the fish from the user
                Console.WriteLine("Enter the species to buy");
                string species = Console.ReadLine();

                // Get the price per fish from the user
                Console.WriteLine("Enter the price per fish");
                double pricePerFish = Convert.ToDouble(Console.ReadLine());

                // Set the species and price using AddFish method
                fishUtility.AddFish(species, pricePerFish);

                // Check if the fish species is valid for buying
                if (fishUtility.BuyFish())
                {
                    // Get the number of fishes from the user
                    Console.WriteLine("Enter the number of fishes you need to buy");
                    int numberOfFishes = Convert.ToInt32(Console.ReadLine());

                    // Calculate the total price using CalculatePrice method
                    double totalCost = fishUtility.CalculatePrice(numberOfFishes);

                    // Print the total cost
                    Console.WriteLine($"Total cost is {totalCost}");
                }
                else
                {
                    // Print an error message if the species is not found
                    Console.WriteLine($"{species} species not found");
                }
            }
        }
    }
}