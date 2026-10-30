using Banking.Console.Interface;

namespace Banking.Console.Models;

public class SavingAccount : Account
{
    // private decimal ReceiverTf { get; set;}
    public SavingAccount(string accountNumber, string ownerName, decimal balance, string tipe, bool isActive) : base(accountNumber, ownerName, balance,  tipe, isActive)
    {
        // ReceiverTf = receiverTf;
    }

    // public void receiverTf()
    // {
        
    // }

}