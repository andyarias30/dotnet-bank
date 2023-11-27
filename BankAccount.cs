public class BankAccount
{

    public double Balance = 0;

    public string OwnersName = "";
    //Contructure
    public BankAccount(string NewOwnersName, double initialBalance)
    {

        this.OwnersName = NewOwnersName;
        this.Deposit(initialBalance);
        this.Deposit(100);
    }

    public double Deposit(double amount)
    {
        if (amount < 0.00)
        {
            throw new Exception("Nope");
        }
        this.Balance += amount;
        return this.Balance;
    }

    public double Withdraw(double amount){

        if(amount < 0){
            throw new Exception("No Negativity");
        }
        if(amount > this.Balance){
            throw new Exception("You don't have that much!");
        }

        // todo send money out atm door
        this.Balance -= amount;
        return this.Balance;
    }

    public double getBalance()
    {
        return this.Balance;
    }

}