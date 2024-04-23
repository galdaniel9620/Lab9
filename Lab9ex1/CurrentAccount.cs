public class CurrentAccount : BankAccount
{
    private decimal overdraftLimit;

    public CurrentAccount(string name, decimal overdraftLimit) : base(name)
    {
        this.overdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= currentBalance)
        {
            currentBalance -= amount;
            Console.WriteLine($"Withdrawn {amount} RON from {name}'s account. Current balance: {currentBalance} RON");
        }
        else if (amount <= currentBalance + overdraftLimit)
        {
            currentBalance -= amount;
            Console.WriteLine($"Withdrawn {amount} RON from {name}'s account with overdraft. Current balance: {currentBalance} RON");
        }
        else
        {
            Console.WriteLine($"Insufficient funds in {name}'s account to withdraw {amount} RON.");
        }
    }

    public override string Description()
    {
        return base.Description() + $", Overdraft Limit: {overdraftLimit} RON";
    }
}