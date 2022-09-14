namespace bank;
using client;

public class BankAccount
{
    // Properties goes here
    private Client _client;
    private int balance;
    private string type;
    
    // Constructor
    public BankAccount(Client client, int balance, string type)
    {
        this._client = client;
        this.balance = balance;
        this.type = type;
    }
    
    // Getters and Setters
    public Client Client
    {
        get { return _client; }
        set { _client = value; }
    }
    
    public int _balance
    {
        get { return balance; }
        set { balance = value; }
    }
    
    public string _type
    {
        get { return type; }
        set { type = value; }
    }
    
    // Methods Bank
    public string CheckBalance()
    {
        return "Your current balance is " + balance;
    }
    
    public int Deposit
    {
        get { return balance; }
        set { balance += value; }
        
    }
    
    public int Withdraw
    {
        get { return balance; }
        set { balance -= value; }
    }
    
}