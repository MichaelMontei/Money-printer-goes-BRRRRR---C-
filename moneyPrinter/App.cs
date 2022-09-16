namespace moneyPrinter;

public sealed class App 
{    
    private static readonly App instance = new App();    
    static App()    
    {    
    }    
    private App()    
    {    
    }    
    public static App Instance    
    {    
        get    
        {    
            return instance;    
        }    
    }

    public void IntroClient()
    {
        Console.WriteLine("Hello there Customer! Press ENTER please!");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("----------------------------");
        Console.WriteLine("----------------------------");
        Console.WriteLine("-------WELCOME TO THE-------");
        Console.WriteLine("---------WE AINT GOT--------");
        Console.WriteLine("--------NO MONEY BANK-------");
        Console.WriteLine("------BELGIUM ANTWERP!------");
        Console.WriteLine("----------------------------");
        Console.WriteLine("----------------------------");
        
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("Please Enter your Name!");
        string customerName = Console.ReadLine() ?? throw new ArgumentNullException("Console.ReadLine()");
        System.Threading.Thread.Sleep(1000);
        string check = "Wazzaaaap " + customerName + ", I am excited to have you here!";
        
    }
}   