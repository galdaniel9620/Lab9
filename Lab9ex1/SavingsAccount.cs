public class SavingsAccount : BankAccount
{
    private decimal interestRate;

    public SavingsAccount(string name, decimal interestRate) : base(name)
    {
        this.interestRate = interestRate;
    }

    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
        currentBalance *= (1 + interestRate); 
        Console.WriteLine($"Current balance of {name}'s savings account has been updated with interest rate. Current balance: {currentBalance} RON");
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= currentBalance)
        {
            currentBalance -= amount;
            Console.WriteLine($"Withdrawn {amount} RON from {name}'s savings account. Current balance: {currentBalance} RON");
        }
        else
        {
            Console.WriteLine($"Insufficient funds in {name}'s savings account to withdraw {amount} RON.");
        }
    }

    public override string Description()
    {
        return base.Description() + $", Interest Rate: {interestRate}";
    }
}