public abstract class BankAccount
{
    protected Guid id;
    protected string name;
    protected decimal currentBalance;

    private Guid Id
    {
        get { return id; }
    }

    public BankAccount(string name)
    {
        this.id = Guid.NewGuid();
        this.name = name;
        this.currentBalance = 0;
    }


    public virtual void Deposit(decimal amount)
    {
        currentBalance += amount;
        Console.WriteLine($"Deposited {amount} RON into {name}'s account. Current balance: {currentBalance} RON");
    }

    public virtual void Withdraw(decimal amount)
    {

    }

    public virtual string Description()
    {
        return $"Account {GetType().Name}: {name}, ID: {id}, Current balance: {currentBalance} RON";
    }
}