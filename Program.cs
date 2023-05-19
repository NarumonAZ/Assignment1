class Program {
    static void Main(string[] args) {
        Console.Write("Input Number: ");
        int number = int.Parse(Console.ReadLine());

        for(int row = 1; row <= number; row++) {
            for(int col = 1; col <= row; col++) {
                Console.Write("{0} ", col);
            }

            Console.WriteLine();
        }
    }
}
