namespace ByteBank.account;

public class Account
{
    private readonly string _name;
    private readonly int _cpf;
    private string _profession;
    private decimal _balance;
    private bool _isClosed;

    public Account(string name, int cpf, string profession)
    {
        this._name = name;
        this._cpf = cpf;
        this._profession = profession;
    }

    public string GetName() => _name;
    public int GetCpf() => _cpf;
    public string GetProfession() => _profession;
    public decimal GetBalance() => _balance;

    public void SetProfession(string newProfession)
    {
        this._profession = newProfession;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            this._balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= this._balance)
        {
            this._balance -= amount;
        }
    }

    public bool Transfer(Account destinationAccount, decimal amount)
    {
        if (amount > this._balance) return false;
        this.Withdraw(amount);
        destinationAccount.Deposit(amount);
        return true;
    }

    public void CloseAccount()
    {
        this._isClosed = true;
    }
    
}