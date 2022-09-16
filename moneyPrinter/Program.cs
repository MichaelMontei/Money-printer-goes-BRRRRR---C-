// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;
using moneyPrinter;

 
    BankAccount bankAccount = new BankAccount(new Client(1, "Michael", DateTime.Today), 100, "savings");
    //Console.WriteLine(bankAccount.CheckBalance());
    //Console.WriteLine(bankAccount.Client._name);
    Console.WriteLine(bankAccount.getInformation());
    //Console.WriteLine(bankAccount._type);
    //Console.WriteLine(bankAccount._balance);

    //Console.WriteLine(bankAccount.CheckBalance());
    //Console.WriteLine(bankAccount.Withdraw);
    //Client client = new Client(1, "Joske", DateTime.Today);
    //Console.WriteLine(client._name);
    //Console.WriteLine(client._id);
    //Console.WriteLine(client._date);
