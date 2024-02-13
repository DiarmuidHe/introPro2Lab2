namespace P2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rainFallTotal = 0;
            int rainFallCm = 0;
            double averageRainFall = 0;
            int totalMonths = 0;
            Console.Write("Years: ");

            int years = int.Parse(Console.ReadLine());
            for (int i = 0; i < years; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write("Cm: ");
                    rainFallCm = int.Parse(Console.ReadLine());
                    rainFallTotal += rainFallCm;
                   
                    totalMonths++;
                }
                
                


                
            }
            averageRainFall = rainFallTotal / 12;
            Console.WriteLine($"TotalMonths: {totalMonths}");
            Console.WriteLine($"Average: {averageRainFall}");
        }
    }
}