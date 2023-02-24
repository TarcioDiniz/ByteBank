namespace ByteBank.account;

public class CurrentAccount : Account
{
    private int _agency;
    private int _account;

    public CurrentAccount(string name, int cpf, string profession) : base(name, cpf, profession)
    {
        SetAgency();
        SetAccount();
    }

    public int GetAgency() => _agency;
    public int GetAccount() => _account;

    private void SetAgency()
    {
        this._agency = 021;
    }

    private void SetAccount()
    {
        var random = new Random();
        this._account = random.Next(0, 9999999);
    }

    public Array GetAccountDetails()
    {
        string[] accountDetails =
        {
            $"{GetAgency()}",
            $"{GetAccount()}",
            $"{GetName()}",
            $"{GetCpf()}",
            $"{GetProfession()}",
            $"{GetBalance()}"
        };

        return accountDetails;
    }
}