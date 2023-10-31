
using BankLibrary;

var bankAccount = new BankAccount("Mr. Bryan Walton", 11.99);

bankAccount.Credit(5.77);
bankAccount.Debit(11.22);

Console.WriteLine("Current balance is ${0}", bankAccount.Balance);