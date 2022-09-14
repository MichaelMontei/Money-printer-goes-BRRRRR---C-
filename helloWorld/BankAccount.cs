namespace DefaultNamespace;

public class BankAccount
{
    private int Balance = 0;
    private string Name;

    public BankAccount(int balance, string name)
    {
        this.Name = name;
        this.Balance = balance;
    }

    public int AddBalance(int amount)
    {
        balance += amount;
    }

    public int SubsctractBalance(int amount)
    {
        balance -= amount;
    }
}