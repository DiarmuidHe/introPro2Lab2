using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace P2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int speed = GetSpeedNumber();
            int time = GetTimeNumber();

            distanceFinder(speed, time);

            
        }
        static int GetSpeedNumber()
        {

            int speed = 0;
            bool greaterThanZero = false;
            while (greaterThanZero == false)
            {
                Console.Write("Speed: ");
                speed = int.Parse(Console.ReadLine());
                if (speed < 1)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    greaterThanZero = true;
                }
            }

            return speed;
        }
        static int GetTimeNumber()
        {

            int time = 0;
            bool greaterThanZero = false;
            while (greaterThanZero == false)
            {
                Console.Write("Time: ");
                time = int.Parse(Console.ReadLine());
                if (time < 1)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    greaterThanZero = true;
                }
            }

            return time;
        }
        static bool ValidNumber(int speed, int time)
        {
            bool greaterThanZero = true;
            if (speed < 1 || time < 1)
            {
                greaterThanZero = false;
            }
            return greaterThanZero;
        }
        static void distanceFinder(int speed, int time)
        {
            int distance = 0;
            for (int i = 1; i <= time; i++)
            {
                distance += speed;
                Console.WriteLine($"{i} {distance}");
            }
            
        }
    }
}