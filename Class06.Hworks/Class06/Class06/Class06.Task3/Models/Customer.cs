namespace Class06.Task3.Models;

class Customer
{
    public string CardNumber { get; private set; }
    private int Pin;
    private decimal Balance;

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Customer(string cardNumber, int pin, string firstName, string lastName, decimal balance)
    {
        CardNumber = cardNumber;
        Pin = pin;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }
    public string Fullname()
    {
        return $"{FirstName} {LastName}";
    }

    public bool ValidatePin(int pin)
    {
        return Pin == pin; 
    }

    public decimal GetBalance()
    {
        return Balance;
    }

    public void DepositCash(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;  
        }
    }

    public bool WithdrawCash(decimal amount)
    {
        if(amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}
