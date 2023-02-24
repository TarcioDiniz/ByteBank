namespace ByteBank.account;

public class CurrentAccount: Account
{
    private int _agency;
    private int _account;
    
    public CurrentAccount(string name, int cpf, string profession) : base(name, cpf, profession)
    {
        SetAgency();
    }

    private void SetAgency()
    {
        this._agency = 021;
    }

    private void SetAccount()
    {
        var random = new Random();
        this._agency = random.Next(0, 9999999);
    }

}