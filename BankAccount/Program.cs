namespace BankAccount
{
    class BankAccount
    {
        public string AccountHolder { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountHolder, decimal initialDeposit)
        {
            AccountHolder = accountHolder;
            Balance = initialDeposit;
        }

        public decimal Deposit(decimal amount)
        {
            decimal updatedBalance;
            updatedBalance = Balance + amount;
            return updatedBalance;
        }

        public decimal Withdraw(decimal amount)
        {
            decimal updatedBalance;
            
            if (amount > Balance)
            {
                updatedBalance = -1;    
            }
            else
            {
                updatedBalance = Balance - amount;
            }
            return updatedBalance;
        }
    }
    class Program
    {
        public static void GetBankAccountInfo(string accountHolder, decimal initialDeposit)
        {
            BankAccount bankAccount = new BankAccount(accountHolder, initialDeposit);
            Console.WriteLine($"{bankAccount.AccountHolder} : {bankAccount.Balance}");
        }

        public static void DepositAndGetBalance(string accountHolder, decimal initialAmount, decimal depositAmount)
        {
            BankAccount bankAccount = new BankAccount(accountHolder, initialAmount);
            Console.WriteLine($"{bankAccount.Deposit(depositAmount)}");
        }

        public static void WithdrawAndGetBalance(string accountHolder,decimal initialAmount, decimal withdrawAmount)
        {
            BankAccount bankAccount = new BankAccount(accountHolder, initialAmount);
            Console.WriteLine($"{bankAccount.Withdraw(withdrawAmount)}");
        }
        public static void Main(string[] args)
        {
            GetBankAccountInfo("Alice", 100);
            DepositAndGetBalance("Bob", 50, 25);
            WithdrawAndGetBalance("Carol", 100, 30);
            WithdrawAndGetBalance("Daniel", 50, 100);
            
        }
    }
}