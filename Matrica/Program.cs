namespace Matrica
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

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[rows, cols] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[rows, cols]:d2}");
                }
                Console.WriteLine();
            }
        }
    }
}
