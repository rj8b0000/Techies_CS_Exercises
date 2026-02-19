namespace ConsoleApp1
{
    class TestBankAccount
    {
        private double balance;

        public TestBankAccount(double balance)
        {
            this.balance = balance;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public bool Deposit(double amount)
        {
            this.balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (this.balance < amount)
            {
                return false;
            }

            this.balance -= amount;
            return true;
        }
    }
    class Program
    {
        public static void PlayBankAccount(int depositAmount, int withdrawAmount)
        {
            TestBankAccount obj1 = new TestBankAccount(depositAmount);
            bool checkWithdraw = obj1.Withdraw(withdrawAmount);
            if (checkWithdraw)
            {
                Console.WriteLine($"Balance: {obj1.GetBalance()}, Withdraw: Success");
            }
            else
            {
                Console.WriteLine($"Balance: {obj1.GetBalance()}, Withdraw: Failed");
            }
            
        }

        static void Main(string[] args)
        {
            PlayBankAccount(10, 12);
        }
    }
}