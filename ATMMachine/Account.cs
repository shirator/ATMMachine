using System;
public class Account
    {
    string name;
    int accountId;
    double balance;

    public Account(string name, int accountId, double balance)
    {
        this.name = name;
        this.accountId = accountId; 
        this.balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"\tYour new balance is {balance}\n");
        }
        else
        {
            Console.WriteLine("\tYou don't have enough balance! =(\n");
        }
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"\tYour new balance is {balance}\n");
    }

    public double CheckBalance()
    {
        return balance;
    }
}
