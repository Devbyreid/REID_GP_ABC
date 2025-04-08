using System;

class AccountBalance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Your Name - Week 4 PA Account Balance Calculations\n");

        double balance = GetStartingBalance();

        while (true)
        {
            try
            {
                double amount = GetValue(balance);

                if (amount == 0)
                {
                    Console.WriteLine("The updated balance is: " + balance.ToString("0.00"));
                    break;
                }

                balance += amount;
                Console.WriteLine("The updated balance is: " + balance.ToString("0.00"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static double GetStartingBalance()
    {
        Console.Write("Please enter the starting balance: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    static double GetValue(double bal)
    {
        Console.Write("Please enter a credit or debit amount (0 to quit): ");
        string input = Console.ReadLine();

        double value;
        if (!double.TryParse(input, out value))
        {
            throw new FormatException("Please enter a numeric value.");
        }

        if (bal + value < 0)
        {
            throw new Exception("Amount entered will cause account to be negative.");
        }

        return value;
    }
}

