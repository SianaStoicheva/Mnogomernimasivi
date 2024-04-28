namespace LotarialenBilet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] lotteryTicket = new int[rows, columns];

            Console.WriteLine("Enter the elements of the ticket:");
            for (int i = 0; i < rows; i++)
            {
                string[] rowElements = Console.ReadLine().Split();
                for (int j = 0; j < columns; j++)
                {
                    lotteryTicket[i, j] = int.Parse(rowElements[j]);
                }
            }

            bool isWinning = IsWinningTicket(lotteryTicket, rows, columns);
            if (isWinning)
            {
                double winnings = CalculateWinnings(lotteryTicket, rows, columns);
                Console.WriteLine($"YES\nThe amount of money won is: {winnings:F2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool IsWinningTicket(int[,] lotteryTicket, int rows, int columns)
        {
            int mainDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int i = 0; i < rows; i++)
            {
                mainDiagonalSum += lotteryTicket[i, i];
                secondaryDiagonalSum += lotteryTicket[i, columns - 1 - i];
            }

            if (mainDiagonalSum != secondaryDiagonalSum)
            {
                return false;
            }

            int aboveMainDiagonalSum = 0;
            int belowMainDiagonalSum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i < j)
                    {
                        aboveMainDiagonalSum += lotteryTicket[i, j];
                    }
                    else if (i > j)
                    {
                        belowMainDiagonalSum += lotteryTicket[i, j];
                    }
                }
            }

            if (aboveMainDiagonalSum % 2 != 0 || belowMainDiagonalSum % 2 != 1)
            {
                return false;
            }

            return true;
        }

        static double CalculateWinnings(int[,] lotteryTicket, int rows, int columns)
        {
            int belowMainDiagonalSum = 0;
            int mainDiagonalEvenSum = 0;
            int outerRowsEvenSum = 0;
            int outerColsOddSum = 0;

            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    belowMainDiagonalSum += lotteryTicket[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (lotteryTicket[i, i] % 2 == 0)
                {
                    mainDiagonalEvenSum += lotteryTicket[i, i];
                }
            }

            for (int j = 0; j < columns; j++)
            {
                outerRowsEvenSum += lotteryTicket[0, j];
                outerRowsEvenSum += lotteryTicket[rows - 1, j];
            }

            for (int i = 0; i < rows; i++)
            {
                outerColsOddSum += lotteryTicket[i, 0];
                outerColsOddSum += lotteryTicket[i, columns - 1];
            }

            double winnings = (belowMainDiagonalSum + mainDiagonalEvenSum + outerRowsEvenSum + outerColsOddSum) / 4.0;
            return winnings;
        }
    
    }
    
}
