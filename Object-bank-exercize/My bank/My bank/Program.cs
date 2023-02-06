// See https://aka.ms/new-console-template for more information
using My_bank;

var agusAccount = new BankAccount("Agus", 60);
Console.WriteLine($"Account {agusAccount.Number} was created for {agusAccount.Owner} with {agusAccount.Balance} dollars starting money");
