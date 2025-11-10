namespace _03._BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BankAccount OBB  = new BankAccount();

            OBB.ID = 1;
            OBB.Balance = 1000;

            Console.WriteLine(OBB);
            OBB.Deposit(1000);
            Console.WriteLine(OBB);

            OBB.Withdraw(5000);
            Console.WriteLine(OBB);

            OBB.PercentIncrease(10);
            Console.WriteLine(OBB);

            OBB.Print();

            Console.WriteLine("========");
            BankAccount DSK=new BankAccount(1,2555.25);
            DSK.Print();
            Console.WriteLine(DSK);
        }
    }
}
