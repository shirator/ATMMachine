using System;

class Program
{
    static void Main(string[] args)
    {
        Account myAccount = new("Carlos Mesquita", 2525, 850.25);

        Console.WriteLine("Your current balance is: " + myAccount.CheckBalance());

        Console.WriteLine("Depositing 500$...\n");
        myAccount.Deposit(500);
        Console.WriteLine("Taking 200$ for the bills...\n");
        myAccount.Withdraw(200);
        Console.WriteLine("Taking 1000$ to buy a PS5!!!\n");
        myAccount.Withdraw(1000);
    }
}