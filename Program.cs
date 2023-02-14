using System;

namespace UT1_BugSquash
{
    // Author: Yanzhi Wang
    // Purpose: Console application to calculate x^y using a recursive function
    // Restrictions: None known
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            int nY; // Missing semicolon
            int nAnswer;

            Console.WriteLine("This program calculates x^y."); // Missing quotation marks

            do
            {
                Console.Write("Enter a whole number for x: ");
                sNumber = Console.ReadLine(); // Save user input to sNumber variable
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nY)); // Save user input to nY variable

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            Console.WriteLine($"{nX}^{nY} = {nAnswer}"); // Use string interpolation to display results
        }

        // Purpose: Compute x^n recursively
        // Restrictions: None known
        // Parameters:
        //     int nBase: the base number
        //     int nExponent: the exponent number
        // Return value: The result of x^n
        static int Power(int nBase, int nExponent)
        {
            int returnVal;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 1; // Fixed incorrect return value
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                int nextVal = Power(nBase, nExponent - 1); // Fixed incorrect exponent value

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            return returnVal; // Fixed missing return statement
        }
    }
}
