using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}