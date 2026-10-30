
using Banking.Console.Models;
using Banking.Console.services;


List<Account> accounts = new List<Account>()
{
    new Account("ACC001", "Andi", 500_000, "Saving", true),
    new Account("ACC002", "Budi", 750_000, "Current", true),
    new Account("ACC003", "Dina", 250_000, "Saving", false),
    new Account("ACC004", "Satrion", 1_000_000, "Current", true),
};

foreach (Account account in accounts)
{
    System.Console.WriteLine(account.GetInformationAccounts());
}

System.Console.WriteLine("=========== ASYNC ACCOUNT SEARCH =============");

var queryService = new AccountQueryService(accounts);
Task<Account?> task1 = queryService.findAccountAsync("Andi");
Task<Account?> task2 = queryService.findAccountAsync("Rizal");


Account?[] results = await Task.WhenAll(task1, task2);

foreach (Account? account in results)
{
    System.Console.WriteLine(account?.GetInformationAccounts() ?? "Account not found");
}
System.Console.WriteLine();