// See https://aka.ms/new-console-template for more information

using ByteBank.account;

CurrentAccount account = new CurrentAccount("João", 123456789, "Desenvolvedor");
Array accountDetails = account.GetAccountDetails();

Console.WriteLine("Detalhes da conta:");
Console.WriteLine($"Agência: {accountDetails.GetValue(0)}");
Console.WriteLine($"Conta: {accountDetails.GetValue(1)}");
Console.WriteLine($"Nome: {accountDetails.GetValue(2)}");
Console.WriteLine($"CPF: {accountDetails.GetValue(3)}");
Console.WriteLine($"Profissão: {accountDetails.GetValue(4)}");
Console.WriteLine($"Saldo: {accountDetails.GetValue(5)}");



CurrentAccount account2 = new CurrentAccount("João2", 123456788, "Desenvolvedor");
string[] accountDetails2 = (string[]) account2.GetAccountDetails();

Console.WriteLine("Detalhes da conta:");
Console.WriteLine(string.Join(Environment.NewLine, accountDetails2));
