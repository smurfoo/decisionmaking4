/*  
 Purpose: Write a program that will compute the income tax due on a taxable income entered by the user. Use
the following table to determine the tax owed:

Input: income
Output: stringmessage
 Author: Ilyas G
Date: Sept 16 2022
 */





namespace decisionmaking4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double income,
                 taxdue;
            string message;

            // input income
            Console.Write("Enter taxable income: ");
            income = double.Parse(Console.ReadLine());
            
            // calculate tax due
            if ( income <= 50000 )
            {
                taxdue = 0 + (income * 0.05);
            }
            else if (income >= 100000)
            {
                taxdue = 2500 + (income * 0.07);
            }
            else
            {
                taxdue = 6000 + (income * 0.09);
            }




            // display message
            Console.WriteLine($" The tax on ${income:f2} is ${taxdue:f2}  ");
            
            
            
            
            
            Console.ReadLine();
        }
    }
}