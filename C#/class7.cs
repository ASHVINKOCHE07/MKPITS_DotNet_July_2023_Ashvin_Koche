using System;

public class BankAccount
{
   public int AccountNumber { get; set; }
   public string AccountHolderName { get; set; }
   public double Balance { get; set; }

   public void Deposit(double amount)
   {
       Balance += amount;
   }

   public void Withdraw(double amount)
   {
       if (amount > Balance)
       {
           Console.WriteLine("Insufficient balance");
           return;
       }
       Balance -= amount;
   }

   public void Transfer(BankAccount fromAccount, BankAccount toAccount, double amount)
   {
       if (amount > fromAccount.Balance)
       {
           Console.WriteLine("Insufficient balance in source account");
           return;
       }
       fromAccount.Withdraw(amount);
       toAccount.Deposit(amount);
   }
}

class Program
{
   static void Main(string[] args)
   {
       BankAccount account1 = new BankAccount
       {
           AccountNumber = 123456,
           AccountHolderName = "Alice",
           Balance = 500.00
       };

       BankAccount account2 = new BankAccount
       {
           AccountNumber = 234567,
           AccountHolderName = "Bob",
           Balance = 800.00
       };

       Console.WriteLine("Initial Balance of Account 1: " + account1.Balance);
       Console.WriteLine("Initial Balance of Account 2: " + account2.Balance);

       double amountToTransfer = 200.00;

       account1.Transfer(account1, account2, amountToTransfer);

       Console.WriteLine("Updated Balance of Account 1: " + account1.Balance);
       Console.WriteLine("Updated Balance of Account 2: " + account2.Balance);
   }
}