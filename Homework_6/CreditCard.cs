//----------------------------Task 2-------------------------------
public class CreditCard
{
    private uint _accountName;
    private decimal _amountAccount;

    public void AddAmount(decimal add)
    {
        _amountAccount += add;
    }
    public void RemoveAmount(decimal remove)
    {
        _amountAccount -= remove;
    }
    public void PrintAccount()
    {
        Console.WriteLine($"Account number: {_accountName}\nAmount on your account: ${_amountAccount}\n");
    }
    public CreditCard(uint accnum,decimal amnt)
    {
        _accountName = accnum;
        _amountAccount = amnt;
    }
}