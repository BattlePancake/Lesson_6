//----------------------------Task 2-------------------------------
public class CreditCard
{
    private uint AccountNumber {get;set;}
    private decimal AmountAccount {get;set;} = 0;

    public void AddAmount()
    {
        Console.Write("Please, choose Amount which will be added on your Account: $");
        decimal add = decimal.Parse(Console.ReadLine());
        AmountAccount += add;
    }
    public void RemoveAmount()
    {
        Console.Write("Please, choose Amount which will be removed from your Account: $");
        decimal remove = decimal.Parse(Console.ReadLine());
        AmountAccount -= remove;
    }
    public void PrintAccount()
    {
        Console.WriteLine($"Account number: {AccountNumber}\nAmount on your account: ${AmountAccount}\n");
    }
    public CreditCard(uint accnum,decimal amnt)
    {
        AccountNumber = accnum;
        AmountAccount = amnt;
    }
}