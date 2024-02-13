namespace P2Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Starting Number: ");
            double startingNum = double.Parse(Console.ReadLine());
            Console.Write("Average Population %: ");
            double averagePercent = double.Parse(Console.ReadLine());
            Console.Write("Number of days: ");
            int numberOfDays = int.Parse(Console.ReadLine());
            
            averagePercent /= 100;
            rateOfExpansion(startingNum, averagePercent, numberOfDays);

        }
        static void rateOfExpansion(double startingNum, double averagePercent, int numberOfDays)
        {
            for (int i = 1; i <= numberOfDays; i++)
            {

                Console.WriteLine($"{i} {startingNum}");
                startingNum += (startingNum * averagePercent);
            }
        }
    }
}