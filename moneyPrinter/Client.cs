namespace moneyPrinter;

public class Client
{
    // Properties Client
    private int id;
    private string name;
    private DateTime date;

    public Client(int id, string name, DateTime date)
    {
        // Constructor Client
        this.id = id;
        this.name = name;
        this.date = date;
    }
    
    // Getters and Setters
    public int _id
    {
        get { return id; }
        set { id = value; }
    }

    public string _name
    {
        get { return name; }
        set { name = value; }
    }

    public DateTime _date
    {
        get { return date; }
        set { date = value; }
    }
}

