public class InvestmentAccount : SavingsAccount
{
    private int withdrawalTerm;

    public InvestmentAccount(string name, decimal interestRate, int withdrawalTerm) : base(name, interestRate)
    {
        this.withdrawalTerm = withdrawalTerm;
    }

    public override void Withdraw(decimal amount)
    {
        if (DateTime.Now.Day < withdrawalTerm)
        {
            Console.WriteLine($"Cannot withdraw from {name}'s investment account until the withdrawal term: {withdrawalTerm}");
        }
        else
        {
            base.Withdraw(amount);
        }
    }

    public override string Description()
    {
        return base.Description() + $", Withdrawal Term: {withdrawalTerm}";
    }
}