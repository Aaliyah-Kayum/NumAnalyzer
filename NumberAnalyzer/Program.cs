public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello! What is your name?");
        string name = Console.ReadLine();
        do
        {
            Console.WriteLine(name + " Please enter a number between 1-100 ");
            int integer = int.Parse(Console.ReadLine());

            if ((integer % 2 != 0) && (integer < 60))
            {
                Console.WriteLine("This number is odd and less than 60 " + name);
            }
            else if ((integer % 2 == 0) && (integer <= 25))
            {
                Console.WriteLine("This number is even and less than 25 " + name);
            }
            else if ((integer % 2 == 0) && (integer >= 26) && (integer <= 60))
            {
                Console.WriteLine("This number is even and between 26 and 60 inclusive");
            }
            else if ((integer % 2 == 0) && (integer >= 60))
            {
                Console.WriteLine("This number is even and greater than 60 " + name);
            }
            else if ((integer % 2 != 0) && (integer >= 60))
            {
                Console.WriteLine("This number is odd and greater than 60 " + name);
            }
            //else if (number <= 0)
            //{
            //    Console.WriteLine("That number was too small " + name);
            //}
            //else if (number >= 100)
            //{
            //    Console.WriteLine("That number was too big " + name);
            //}
            else
            {
                Console.WriteLine("Please remember to select a number between 1-100 and try again " + name);
            }
            //switch (integer)
            //{
            //    case <= 60:
            //        Console.WriteLine("This number is Odd and less than 60");
            //        break;
            //    case >= 60:
            //        Console.WriteLine("This number is Odd and greater than 60");
            //        break;
            //    default:
            //        Console.WriteLine("You entered an invalid input. Please try again");
            //        break;
            Console.WriteLine($"Do you wish to keep looping {name}? y/n");
            string looping = Console.ReadLine();

            if (looping == "y")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Thank you for using the Number Analyzer");
                Console.WriteLine($"Good bye {name}!");
                break;
            }
        }
        while (true);
    }
}
        