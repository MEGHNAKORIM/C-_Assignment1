using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine("Number1 and Number2 are equal");
        }
        else
        {
            Console.WriteLine("Number1 and Number2 are not equal");
        }

        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }

        Console.Write("Enter the first side of the triangle: ");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second side of the triangle: ");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third side of the triangle: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        if (side1 + side2 + side3 != 180)
        {
            Console.WriteLine("Not a valid triangle. The sum of the angles must be 180 degrees.");
        }
        else
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This is an equilateral triangle.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("This is an isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is a scalene triangle.");
            }
        }
    }
}
