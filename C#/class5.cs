using System;

namespace BankCustomer
{
    class BankCustomer
    {
        public string CustomerName { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankCustomer(string name, int number, double balance)
        {
            CustomerName = name;
            AccountNumber = number;
            Balance = balance = Console.ReadLine();
            Console.Write("Enter account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            BankCustomer customer = new BankCustomer(name, number, balance);

            // Simulate deposits and withdrawals from the customer's account
            int cnt = 1;
            for (; cnt <= 3; cnt++)
            {
                Console.WriteLine("Deposit or withdrawal {0}: ", cnt);
                Console.Write("Enter 1 for deposit, 2 for withdrawal: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter deposit amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    customer.Deposit(amount);
                    Console.WriteLine("Deposit successful. New balance: {0}", customer.Balance);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter withdrawal amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    customer.Withdraw(amount);
                    Console.WriteLine("Withdrawal successful. New balance: {0}", customer.Balance);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }

            Console.WriteLine("Final balance: {0}", customer.Balance);
        }
    }
}