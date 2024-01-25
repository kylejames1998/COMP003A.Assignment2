// Author: Kyle James
// Course: COMP003A
// Purpose: COMP003A Assignment 2
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console Section
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("*********************************************************");
            Console.Title = "COMP003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            // these 2 console.WriteLine's are here to add space between sections
            Console.WriteLine();
            Console.WriteLine();


            // String Section
            Console.WriteLine("*********************************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("*********************************************************");
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Enter your last name ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your age in 2023: ");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");
            // these 2 console.WriteLine's are here to add space between sections
            Console.WriteLine();
            Console.WriteLine();


            // Math Section
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("**********************************************************");
            Console.Write("Enter an integer for integer 1: ");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integer for integer 2: ");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");
            // these 2 console.WriteLine's are here to add space between sections
            Console.WriteLine();
            Console.WriteLine();


            // Area & Circumference Section
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Circle Area & Circumference Calculator Section");
            Console.WriteLine("*********************************************************");
            Console.Write("Enter Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The area is: {area}");
            Console.WriteLine($"The circumference is {circumference}");


        }
    }
}
