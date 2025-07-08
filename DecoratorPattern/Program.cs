using System;

class Program
{
    static void Main()
    {
        ICoffee coffee = new BasicCoffee();

        while (true)
        {
            Console.WriteLine("Current Coffee: " + coffee.GetDescription() + $" (${coffee.GetCost():0.00})");
            Console.WriteLine("Add topping:");
            Console.WriteLine("1. Milk (+$0.50)");
            Console.WriteLine("2. Sugar (+$0.20)");
            Console.WriteLine("3. Whip Cream (+$0.70)");
            Console.WriteLine("4. Done");

            Console.Write("Enter choice (1-4): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    coffee = new MilkDecorator(coffee);
                    break;
                case "2":
                    coffee = new SugarDecorator(coffee);
                    break;
                case "3":
                    coffee = new WhipCreamDecorator(coffee);
                    break;
                case "4":
                    Console.WriteLine("\nFinal Coffee: " + coffee.GetDescription());
                    Console.WriteLine("Total Cost: $" + coffee.GetCost().ToString("0.00"));
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
