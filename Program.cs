namespace CoffeMachine
{
    internal class Program
    {

        // Nils Olmås BUV26
        static void Main(string[] args)
        {
            // CoffeMachine program that allows for 3 choices of coffe sizes
            // The program will ask the user to select a size
            // which is then added to the total price of the order
            // The user is asked to continue (yes or no)
            // and it will loop until the user says no
            // We then print the total price of the order and break the loop
            Console.WriteLine("CoffeMachine 1.0_FINAL_FINAL");

            // This is the total price of the order
            int OrderTotal = 0;
            // This is the loop that will continue until the user says no
            while (true)
            {
                Console.Write("Please select the size of your coffe, 1 for small, 2 for medium, 3 for large: ");
                // This is the user input for the size of the coffe
                string Order = Console.ReadLine();
                // We use switch and case to determine the price to add to the total
                switch (Order)
                {
                    case "1":
                        // Input 1 = + 15 to the total
                        OrderTotal += 15;
                        break;
                    case "2":
                        // Input 2 = + 20 to the total
                        OrderTotal += 20;
                        break;
                    case "3":
                        // Input 3 = + 25 to the total
                        OrderTotal += 25;
                        break;
                    default:
                        // If the user inputs anything other than 1, 2, or 3, we print an error message
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.Write("Would you like to order another coffe? Yes or No: ");
                // This is the user input for whether they want to continue ordering
                string NextOrder = Console.ReadLine().ToLower();
                // We run another loop to check if the user input is valid (yes or no)
                while (NextOrder != "yes" && NextOrder != "no")
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.Write("Would you like to order another coffe? Yes or No: ");
                    NextOrder = Console.ReadLine().ToLower();
                }
                if (NextOrder == "yes")
                {
                    // If yes, we continue the orignial loop
                    continue;
                }
                else if (NextOrder == "no")
                {
                    // If no, we print the total price of the order and break the loop
                    Console.WriteLine("Your total is: " + OrderTotal + " kr");
                    Console.WriteLine("Thank you and come again!");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
