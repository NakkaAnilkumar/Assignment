using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, temp;

            Console.Write("Input the First Number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            secondNumber = int.Parse(Console.ReadLine());

            // Swapping logic
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + firstNumber);
            Console.WriteLine("Second Number: " + secondNumber);
            Console.ReadLine();


            //}
            // problem number2----------------------------------------------------------------
            //{
            double firstNum, secondNum, thirdNum, result;

            Console.Write("Input the first number to multiply: ");
            firstNum = double.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            secondNum = double.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            thirdNum = double.Parse(Console.ReadLine());

            // Multiplication logic
            result = firstNum * secondNum * thirdNum;

            Console.WriteLine($"{firstNum} x {secondNum} x {thirdNum} = {result}");
            Console.ReadLine();

            //problem number 3-----------------------------------------------------------------

            double first, second, sum, difference, product, quotient;
            int modulus;

            Console.Write("Input the first number: ");
            first = double.Parse(Console.ReadLine());

            Console.Write("Input the second number: ");
            second = double.Parse(Console.ReadLine());

            // Perform calculations
            sum = first + second;
            difference = first - second;
            product = first * second;
            quotient = first / second;
            modulus = (int)(first % second);

            // Print results
            Console.WriteLine($"{first} + {second} = {sum}");
            Console.WriteLine($"{first} - {second} = {difference}");
            Console.WriteLine($"{first} x {second} = {product}");
            Console.WriteLine($"{first} / {second} = {quotient}");
            Console.WriteLine($"{first} mod {second} = {modulus}");
            Console.ReadLine();

            //problem number 4 ------------------------------------------------------------------------------

            double x, y, z;

            Console.Write("Enter first number: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = double.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            z = double.Parse(Console.ReadLine());

            // Calculate expressions
            double result1 = (x + y) * z;
            double result2 = (x * y) + (y * z);

            // Print results
            Console.WriteLine($"Result of specified numbers {x}, {y}, and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");
            Console.ReadLine();

            //problem number 5 ---------------------------------------------------------------------------

            Console.Write("Enter a digit: ");
            int number = int.Parse(Console.ReadLine());

            // Using Console.Write
            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");

            // Using {0} string formatting
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.ReadLine();

            //problem number 8---------------------------------------------------------------------------------

            Console.Write("Enter the amount of Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            // Convert Celsius to Kelvin
            double kelvin = celsius + 273.15;

            // Convert Celsius to Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");
            Console.ReadLine();

            //problem number 9-------------------------------------------------------------------------------------

            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int add = num1 + num2;

            if (num1 == num2)
            {
                int tripleSum = 3 * add;
                Console.WriteLine($"The values are equal, so the triple sum is {tripleSum}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"The sum of the two integers is {add}");
                Console.ReadLine();
            }

                //problem number 10-----------------------------------------------------------------------------

                Console.Write("Enter the first number: ");
                double numb1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double numb2 = double.Parse(Console.ReadLine());

                double absoluteDifference = Math.Abs(numb1 - numb2);

                if (numb1 > numb2)
                {
                    double doubleAbsoluteDifference = 2 * absoluteDifference;
                    Console.WriteLine($"The first number is greater, so double the absolute difference is {doubleAbsoluteDifference}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"The absolute difference between the two numbers is {absoluteDifference}");
                    Console.ReadLine();
                }

            //problem number 11----------------------------------------------------------------------------------------

            Console.Write("Enter the number of days: ");
            int totalDays = int.Parse(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            int days = remainingDays % 7;

            Console.WriteLine($"{totalDays} days is equivalent to:");
            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {days}");
            Console.ReadLine() ;

            //problem number 6--------------------------------------------------------------------------------------------

            Console.Write("Enter marks for Subject 1: ");
            int subject1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 2: ");
            int subject2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 3: ");
            int subject3 = Convert.ToInt32(Console.ReadLine());

            // Calculate total marks and percentage
            int totalMarks = subject1 + subject2 + subject3;
            double percentage = (totalMarks / 3.0);


            string grade;
            if (percentage < 35)
            {
                grade = "Fail";
            }
            else if (percentage >= 35 && percentage < 45)
            {
                grade = "Third";
            }
            else if (percentage >= 45 && percentage < 60)
            {
                grade = "Second";
            }
            else
            {
                grade = "First";
            }

            // Display results
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine($"Grade: {grade}");
            Console.ReadLine();

            //problem number 7--------------------------------------------------------------------------------

            Console.Write("Enter the first number: ");
            double numbe1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double numbe2 = double.Parse(Console.ReadLine());

            double max = Math.Max(num1, num2);
            double min = Math.Min(num1, num2);

            Console.WriteLine($"Maximum of {numbe1} and {numbe2} is: {max}");
            Console.WriteLine($"Minimum of {numbe1} and {numbe2} is: {min}");
            Console.ReadLine() ;


        }
    }
}

