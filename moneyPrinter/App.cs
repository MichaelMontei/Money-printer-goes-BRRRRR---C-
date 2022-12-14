namespace moneyPrinter;

public class Bank
{
    private string _bankName;

    public Bank(string bankName)
    {
        _bankName = bankName;
    }

    public string BankName
    {
        get => _bankName;
        set => _bankName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void Greeting()
    {
        Console.WriteLine($"Welcome to {_bankName}. We have noticed you are not registered with us already, would you like to register? y/n");
    }

    public void HandleRegistration()
    {
        string? responseRegistration = Console.ReadLine();
        while (!(responseRegistration == "y" || responseRegistration == "n"))
        {
            Console.WriteLine("Please use words I can understand I am but a mere computer.");
            Console.WriteLine("Do you want to register? y/n");
            responseRegistration = Console.ReadLine();
        }

        if (responseRegistration == "no" || responseRegistration == "n")
        {
            Console.WriteLine("Understandable, have a day.");
        }
    }

    public BankAccount Register()
    {
        //add error handling to money deposit
        Console.WriteLine("What is your name?");
        var clientName = Console.ReadLine();
        string registerDate = DateTime.Today.ToString("d");
        
        //find a way to add auto incrementing feature for ID number, so multiple people can register under different ID's
        int clientID = 1;
        
        Console.WriteLine("How much money would you like to deposit on this account?");
        int depositAmount;
        depositAmount = Convert.ToInt32(Console.ReadLine());

        while (depositAmount < 5)
        {
            Console.WriteLine("The minimum amount of money you can deposit to your account is 5 euros, please try again.");
            depositAmount = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("What type of bankaccount do you want? \n a). Savings \n b). Normal");
        var bankAccountType = Console.ReadLine();
        while (bankAccountType is not ("a" or "b"))
        {
            Console.WriteLine("Please input 'a' if you want a savings account, or 'b' if you want a normal account.");
            bankAccountType = Console.ReadLine();
        }

        if (bankAccountType == "a")
        {
            bankAccountType = "Savings";
        }
        else if (bankAccountType == "b")
        {
            bankAccountType = "Normal";
        }
        //confirmation
        Console.WriteLine($"Your name is {clientName}, you have deposited {depositAmount} euros into your new {bankAccountType} bankaccount. \n Is this correct? y/n");
        var confirmRegistration = Console.ReadLine();

        while (!(confirmRegistration == "y" || confirmRegistration == "n"))
        {
            Console.WriteLine("Please input 'y' if you'd like to confirm the registration and 'n' if some information is incorrect. ");
            confirmRegistration = Console.ReadLine();
        }

        //here I create a bank account and a client depending on the user's data
        if (confirmRegistration == "y")
        {
            Console.WriteLine($"Welcome {clientName}");
            BankAccount newBankAccount = new BankAccount(new Client (1, $"{clientName}", registerDate), depositAmount, $"{bankAccountType}");
            return newBankAccount;
        }
        else
        {
            Console.WriteLine("Have a day.");
            return null;
        }
    }
}