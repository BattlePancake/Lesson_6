//----------------------------Task 1-------------------------------
using System.Text;

public class Phone
{
    private string _number;
    private string _model;
    private int _weight;

    public Phone()
    {
    }
    public Phone(string mod, string num)
    {
        _model = mod;
        _number = num;
    }
    public Phone(string mod, string num, int wgt): this(mod,num)
    {
        _weight = wgt;
    }

    public void Print()
    {
        Console.WriteLine($"Model: {_model}, Number: {_number}, Weigth: {_weight}");
    }
    public void ReceiveCall(string name)
    {
        Console.WriteLine($"Calls: {name}");
    }
    public void ReceiveCall(string name,string phnum)
    {
        Console.WriteLine($"Calls: {name}, Phone number: {phnum}");
    }
    public void GetNumber(string phnum)
    {
        Console.WriteLine($"Phone number: {phnum}");
    }
    public void SendMessage(string[] phnums)
    {
        Console.WriteLine($"Phone numbers:");
        foreach(string a in phnums)
        {
            Console.Write($"{a}  ");
        }
    }
}