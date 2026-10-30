namespace Banking.Console.Models;

public class Account
{
    public string AccountNumber {get; set;}
    public string OwnerName {get; set;}
    public decimal Balance {get; set;}

    public string Tipe {get; set;}
    public bool IsActive {get; set;}
    public string Status => IsActive ? "Active" : "Frozen";


    public Account(string accountNumber, string ownerName, decimal balance, string tipe, bool isActive = true)
    {
        if(accountNumber == null)
        {
            throw new ArgumentException("Account Number is required");
        }

        if(ownerName == null)
        {
            throw new ArgumentException("Owner Name is required");
        }

        if(balance <= 0)
        {
            throw new ArgumentException("Balance negative number");
        }
        if(tipe == null)
        {
            throw new ArgumentException("type tidak valid");
        }

        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
        IsActive = isActive;
        Tipe = tipe;
    }

    public virtual decimal GetTfBalance()
    {
        return Balance;
    }

    public virtual string GetInformationAccounts()
    {
        return $"Type: {Tipe}\nAccount Number: {AccountNumber}\nName: {OwnerName}\nBalance: {Balance}\nStatus: {IsActive}\n";
    }

    public virtual void TransferReceiver(decimal jumlahTf)
    {
        if(jumlahTf < 0)
        {
            throw new ArgumentException("Jumlah harus positif");
        }

        Balance = checked(jumlahTf + Balance);
    }

    public void SendTf(decimal sendTf)
    {
        Balance -= sendTf;
    }
}