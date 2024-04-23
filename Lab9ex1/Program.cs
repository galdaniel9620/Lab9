using System;


BankAccount account1 = new CurrentAccount("Current Account", 5000);
account1.Deposit(1000);
account1.Withdraw(2000);
account1.Withdraw(2000);
account1.Withdraw(2000);
account1.Withdraw(2000);
Console.WriteLine();

BankAccount account2 = new SavingsAccount("Savings Account", 0.05m);
account2.Deposit(3000);
account2.Withdraw(2000);
account2.Withdraw(2000);
account2.Withdraw(2000);
Console.WriteLine();


BankAccount account3 = new InvestmentAccount("Investment Account", 0.07m, 15);
account3.Deposit(10000);
account3.Withdraw(5000);
Console.WriteLine();

Console.WriteLine(account1.Description());
Console.WriteLine(account2.Description());
Console.WriteLine(account3.Description());

