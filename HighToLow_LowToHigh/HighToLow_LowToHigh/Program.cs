internal class Program
{
    private static void Main(string[] args)
    {

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("Enter 3 values \n 1: ");
        int numb1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2: ");
        int numb2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3: ");
        int numb3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");

        if (numb1 > numb2 && numb1 > numb3)
        {
            if (numb2 > numb3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("High to Low");
                Console.WriteLine(numb1 + " " + numb2 + " " + numb3);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("High to Low");
                Console.WriteLine(numb1 + " " + numb3 + " " + numb2);
            }
        }
        else if (numb2 > numb3 && numb2 > numb1)
        {
            if (numb3 > numb1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("High to Low");
                Console.WriteLine(numb2 + " " + numb3 + " " + numb1);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("High to Low");
                Console.WriteLine(numb2 + " " + numb1 + " " + numb3);
            }
        }
        else if (numb3 > numb1 && numb3 > numb2)
        {
            if (numb2 > numb1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("High to Low");
                Console.WriteLine(numb3 + " " + numb2 + " " + numb1);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("High to Low");
                Console.WriteLine(numb3 + " " + numb1 + " " + numb2);
            }
        }
        else
        {
            Console.WriteLine("They are all same!");
        }

        Console.WriteLine("\n");

        if (numb1 > numb2 && numb1 > numb3)
        {
            if (numb2 > numb3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Low to High");
                Console.WriteLine(numb3 + " " + numb2 + " " + numb1);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Low to High");
                Console.WriteLine(numb2 + " " + numb3 + " " + numb1);
            }
        }
        else if (numb2 > numb3 && numb2 > numb1)
        {
            if (numb3 > numb1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Low to High");
                Console.WriteLine(numb1 + " " + numb3 + " " + numb2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Low to High");
                Console.WriteLine(numb3 + " " + numb1 + " " + numb2);
            }
        }
        else if (numb3 > numb1 && numb3 > numb2)
        {
            if (numb2 > numb1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Low to High");
                Console.WriteLine(numb1 + " " + numb2 + " " + numb3);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Low to High");
                Console.WriteLine(numb2 + " " + numb1 + " " + numb3);
            }
        }
        else
        {
            Console.WriteLine("They are all same!");
        }

    }
}