namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int sodaStock = 100;
            int chipsStock = 40;
            int candyStock = 60;
            int sodaRestockThreshold = 40;
            int chipsRestockThreshold = 20;
            int candyRestockThreshold = 40;

            
            Console.Write("How many sodas have been sold today? ");
            int soldSodas;
            if (int.TryParse(Console.ReadLine(), out soldSodas))
            {
               
                int remainingSodaStock = sodaStock - soldSodas;
                if (remainingSodaStock >= 0)
                {
                    Console.WriteLine($"Remaining soda stock: {remainingSodaStock}");
                    
                    if (remainingSodaStock <= sodaRestockThreshold)
                        Console.WriteLine("Soda needs to be restocked.");
                }
                else
                {
                    Console.WriteLine("Too high! Cannot sell more sodas than in stock.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            
            Console.Write("How many chips have been sold today? ");
            int soldChips;
            if (int.TryParse(Console.ReadLine(), out soldChips))
            {
                int remainingChipsStock = chipsStock - soldChips;
                if (remainingChipsStock >= 0)
                {
                    Console.WriteLine($"Remaining chips stock: {remainingChipsStock}");
                    if (remainingChipsStock <= chipsRestockThreshold)
                        Console.WriteLine("Chips need to be restocked.");
                }
                else
                {
                    Console.WriteLine("Too high! Cannot sell more chips than in stock.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

         
            Console.Write("How many candies have been sold today? ");
            int soldCandy;
            if (int.TryParse(Console.ReadLine(), out soldCandy))
            {
                int remainingCandyStock = candyStock - soldCandy;
                if (remainingCandyStock >= 0)
                {
                    Console.WriteLine($"Remaining candy stock: {remainingCandyStock}");
                    if (remainingCandyStock <= candyRestockThreshold)
                        Console.WriteLine("Candy needs to be restocked.");
                }
                else
                {
                    Console.WriteLine("Too high! Cannot sell more candies than in stock.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");