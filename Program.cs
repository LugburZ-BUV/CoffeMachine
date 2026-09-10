namespace CoffeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CoffeMachine 1.0_FINAL_FINAL");
            int OrderTotal = 0;
            while (true)
            {
                Console.Write("Please select the size of your coffe, 1 for small, 2 for medium, 3 for large: ");
                string Order = Console.ReadLine();
                switch (Order)
                {
                    case "1":
                        OrderTotal += 15;
                        break;
                    case "2":
                        OrderTotal += 20;
                        break;
                    case "3":
                        OrderTotal += 25;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.Write("Would you like to order another coffe? Yes or No: ");
                string NextOrder = Console.ReadLine().ToLower();
                if (NextOrder == "yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Your total is: " + OrderTotal + " kr");
                    Console.WriteLine("Thank you and come again!");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
