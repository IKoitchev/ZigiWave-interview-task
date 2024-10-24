
class Program
{
    private static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int M = Convert.ToInt32(Console.ReadLine());
        
        int nrIslands = 0;

        if (N < 3 || M < 3) {
            Console.WriteLine(nrIslands);
            return;
        }   
        int[,] matrix = new int[N, M];

        // Input matrix one number at a time
        for (int i = 0; i < M; i++){
            for (int j = 0; j < N; j++){
                matrix [j,i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        

    }
}