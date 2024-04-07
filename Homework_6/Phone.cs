//----------------------------Task 1-------------------------------
using System.Text;

public class Phone
{
    public string Number;
    public string Model;
    private int Weight;

    public void Print()
    {
        Console.WriteLine($"Model: {Model}, Number: {Number}, Weigth: {Weight}");
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

    public Phone()
    {
    }
    public Phone(string mod, string num)
    {
        Model = mod;
        Number = num;
    }
    public Phone(string mod, string num, int wgt): this(mod,num)
    {
        Weight = wgt;
    }
}