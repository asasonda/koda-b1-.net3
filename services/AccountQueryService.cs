using Banking.Console.Models;

namespace Banking.Console.services;

public class AccountQueryService
{
    private readonly IReadOnlyList<Account> _accounts;

    public AccountQueryService(IReadOnlyList<Account> accounts)
    {
        _accounts = accounts;
    }

    public async Task<Account?> findAccountAsync(string ownerName)
    {
        await Task.Delay(2000);

        return _accounts.FirstOrDefault(
            account => account.OwnerName == ownerName
        );
    }
}