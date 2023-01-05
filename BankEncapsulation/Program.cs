namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("how many dollars would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);
            Console.WriteLine($"thank you! youre balance is now ${account.GetBalance()}");
        }
    }
}
