
class Program
{
    private static void Main(string[] args)
    {
        // Vertical
        Console.WriteLine("Enter the number or rows:");
        int N = Convert.ToInt32(Console.ReadLine());
        // Horizontal

        Console.WriteLine("Enter the number or columns:");
        int M = Convert.ToInt32(Console.ReadLine());

        int nrIslands = 0;

        if (N < 3 || M < 3)
        {
            Console.WriteLine(nrIslands);
            return;
        }

        int[,] matrix = new int[N, M];

        bool[,] covered = new bool[N, M];


        Console.WriteLine($"Please enter {M} space separated numbers per row:");

        // Input matrix one number at a time
        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();

            int[] numbers = input.Split(" ").Select(int.Parse).ToArray();
            for (int j = 0; j < M; j++)
            {
                matrix[i, j] = numbers[j];
            }
        }


        for (int i = 1; i < N - 1; i++)
        {
            for (int j = 1; j < M - 1; j++)
            {

                if (matrix[i, j] == 1 && !covered[i, j])
                {
                    FindIslands(matrix, i, j);

                    nrIslands++;
                }


            }
        }

        void FindIslands(int[,] matrix, int startN, int startM)
        {
            // Offset coordinate pairs to look for adjacent land pieces
            int[] verticalOffset = { -1, 0, 1, 0 };
            int[] horizontalOffset = { 0, 1, 0, -1 };

            covered[startN, startM] = true;

            // Every direction
            for (int i = 0; i < 4; ++i)
            {
                int nextVertical = startN + verticalOffset[i];
                int nextHorizontal = startM + horizontalOffset[i];

                // All need to be true to find the island
                bool[] conditions = [nextVertical >= 0,
                                    nextHorizontal >= 0,
                                    nextVertical < N,
                                    nextHorizontal < M,
                                    matrix[nextVertical,nextHorizontal] == 1,
                                    !covered[nextVertical, nextHorizontal]];

                if (!conditions.Any(c => c == false))
                {
                    FindIslands(matrix, nextVertical, nextHorizontal);
                }
            }
        }


        Console.WriteLine(nrIslands);
    }
}