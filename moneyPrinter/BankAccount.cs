namespace moneyPrinter;
public class BankAccount
{
    // Properties
    private Client _client;
    private int _balance;
    private string _type;
    
    // Constructor
    public BankAccount(Client client, int balance, string type)
    {
        _client = client;
        _balance = balance;
        _type = type;
    }

    // Getters And Setters
    private Client Client
    {
        get => _client;
        set => _client = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Balance
    {
        get => _balance;
        set => _balance = value;
    }

    public string Type
    {
        get => _type;
        set => _type = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    // Methods Bank
    private void CheckBalance()
    {
        Console.WriteLine($"Your balance is: {_balance}");
        OptionsBanking();
    }

    private void Deposit()
    {
        Console.WriteLine("How much euros would you like to deposit?");

        var depositAmount = Convert.ToInt32(Console.ReadLine());
        while (depositAmount <=0)
        {
            Console.WriteLine("I'm sorry, but you can't deposit an amount that's lower than or equal to zero. \n Please select a new amount you'd like to deposit.");
            depositAmount = Convert.ToInt32(Console.ReadLine());
        }
        
        _balance += depositAmount;

        Console.WriteLine($"You have successfully deposited: {depositAmount} euros.");
        OptionsBanking();
    }

    private void Withdraw()
    {
        Console.WriteLine($"How much would you like to withdraw?");
        var withdrawAmount = Convert.ToInt32(Console.ReadLine());
        
        while (withdrawAmount > _balance)
        {
            Console.WriteLine("I'm sorry, but you can't withdraw an amount that's higher than your current balance. \n Please select a new amount you'd like to withdraw.");
            withdrawAmount = Convert.ToInt32(Console.ReadLine());
        }
        
        _balance -= withdrawAmount;

        Console.WriteLine($"You have successfully withdrawn: {withdrawAmount} euros.");
        OptionsBanking();
    }

    private void LeaveBank()
    {
        Console.WriteLine($"Thanks a lot {Client.Name}. \n I wish you a very nice day!");
    }

    public void OptionsBanking()
    {
        Console.WriteLine($"What would you like to do next: {_client.Name}? \n a. Check your balance? \n b. Deposit money? \n c. Withdraw money? \n d. Close your banking app?");
        var optionsAnswers = Console.ReadLine();
        switch (optionsAnswers)
        {
            case "a":
                CheckBalance();
                break;
            case "b":
                Deposit();
                break;
            case "c":
                Withdraw();
                break;
            case "d":
                LeaveBank();
                break;
        }
    }
    
}
