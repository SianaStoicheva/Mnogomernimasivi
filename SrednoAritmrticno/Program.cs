namespace SrednoAritmrticno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete elementite na matricata:");
            Console.Write("Vuvedete broi redove:");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Vuvedi broi koloni:");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                double sum = 0;
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                    Console.Write("{0,10}", matrix[row, col]);
                }
                double average = sum / cols;
                Console.WriteLine("{0,10:F2}", average);
            }
        }
    }
}
