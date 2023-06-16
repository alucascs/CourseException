using CourseException.Entities;
using CourseException.Entities.Exceptions;
using System;
using System.Globalization;

namespace CourseException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number, holder, balance, limit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.WithDraw(amount);
                Console.Write("New balance: " + acc.Balance.ToString("f2", CultureInfo.InvariantCulture));
            }
            catch (DominionException e)
            {
                Console.WriteLine("Withdraw Error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error: " + e.Message);
            }
        }
    }
}