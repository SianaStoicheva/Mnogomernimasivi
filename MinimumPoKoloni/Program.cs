namespace MinimumPoKoloni
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
                int[] rowArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }
            int[] minElements = new int[cols];

            for (int col = 0; col < cols; col++)
            {
                int min = int.MaxValue;
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] < min)
                    {
                        min = matrix[row, col];
                    }
                }
                minElements[col] = min;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col],5}");
                }
                Console.WriteLine();
            }

            for (int col = 0; col < cols; col++)
            {
                Console.Write($"{minElements[col],5}");
            }
            Console.WriteLine();

        }
    }
}
