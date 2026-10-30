namespace Banking.Console.Models;

public class CurrentAccount : Account
{
    public CurrentAccount(string accountNumber, string ownerName, decimal balance, string tipe, bool isActive) : base(accountNumber,ownerName, balance, tipe, isActive)
    {
        
    }
}