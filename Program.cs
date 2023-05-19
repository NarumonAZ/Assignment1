class Program
{

    static void Main(string[] args)
    {
        Console.Write("Input Row: ");
        int row;

        do
        {
            row = int.Parse(Console.ReadLine());
            if (row >= 0)
            {
                MakeTriangle(row);
            }
            else
            {
                Console.WriteLine("Invalid Pascal is triangle row number.");
            }
        } while (row < 0);
    }

    static void MakeTriangle(int row)
    {
        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                int n = Factorial(i) / (Factorial(j) * Factorial(i - j));
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
        }
    }

    static int Factorial(int n)
    {
        int factorial = 1;
        if (n > 0)
        {
            return n * Factorial(--n);
        }
        else
        {
            return factorial;
        }
    }
}