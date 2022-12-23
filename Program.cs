
    class program
{
    static bool Isperfect(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) sum += i;
        }
        if (sum == number) return true;
        return false;

    }

    static void Main(string[] args)
    {
        int x, y;
        Console.Write("Please enter the first number:");
        x = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number :");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        for (int i=x; i<=y; i++)
        {
            if(Isperfect(i)) Console.Write("{0}, ", i);
        }
        Console.ReadKey();


      }


    }


