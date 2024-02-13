using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Question: ");
            int question = int.Parse(Console.ReadLine());
            if (question == 1)
            {
                Q1 ();
            }
            else if (question == 2) 
            {
                Q2 ();
            }
            else if (question == 3)
            {
                Q3 ();
            }
            else if (question == 4)
            {
                Q4();
            }
            else if (question == 5)
            {
                Q5();
            }
        }


        static void Q1()
        {
            Console.Write("Integer 1: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.Write("Integer 2: ");
            int numTwo = int.Parse(Console.ReadLine());
            int answer = SumOddNumbers(numOne, numTwo);

            Console.WriteLine(answer);
        }
        static int SumOddNumbers (int num1, int num2) 
        { 
            int numberAddition = 0;
            int temp = 0;
            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            
            for (int i = num1; i <= num2; i++)
            {
                
                if (i % 2 == 1)
                {
                    numberAddition += i;
                    
                }
            }
            return numberAddition;
        }






        static void Q2()
        {
            int i = 0;
            var array = new List<int>();

            Console.Write("Number: ");
            array.Add(int.Parse(Console.ReadLine()));

            while (array[i] != -999)
            {

                i++;
                Console.Write("Number: ");
                array.Add(int.Parse(Console.ReadLine()));

            }
            array.Remove(-999);
            bool result = IsSortedAscending(array);
            Console.WriteLine(result);
        }
        static bool IsSortedAscending(List<int> anArray)
        {
            bool result = true;

            for (int i = (anArray.Count - 1); i > 0; i--)
            {

                if (anArray[i] >= anArray[i - 1])
                {
                    result = false;
                }
            }
            return result;
        }













        static void Q3()
        {
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            bool validAge = IsvalidAge(age);
            Console.WriteLine(validAge);
        }
        static bool IsvalidAge(int age)
        {
            bool validAge = false;

            if (age <= 21 && age >= 18)
            {
                validAge = true;
            }
            return validAge;
        }

        static void Q4()
        {
            int[] line = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            line = AllTheLines(line);
        }
        
        static int[] AllTheLines(int[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = 9;
                Console.Write($"{lines[i]} ");
            }
            return lines;
        }


        static void Q5()
        {
            int passValue = 0;
            int[] line = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int[] line2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            passValue = CountPasses(line, passValue);
            Console.WriteLine(passValue);
            passValue = CountPasses(line2, passValue);
            Console.WriteLine(passValue);
        }
        static int CountPasses(int[] marks, int passValue)
        {
            
            
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] >= 40)
                {
                    passValue++;
                }
            }
            return passValue;
        }
       
       
        static void Q7()
        {

        }
        static double CostOfProducts(string productCode)
        {
            double cost = 0;
            switch (productCode)
            {
                case "abc":
                    cost = 10.10;
                    break;
                case "xyz":
                    cost = 10.10;
                    break;
                case "fr45":
                    cost = 10.10;
                    break;
                case "s34":
                    cost = 5;
                    break;
                case "g65":
                    cost = 5;
                    break;
                case "f34":
                    cost = 5;
                    break;


            }
        }
    }
}