public abstract class Account : IAccount
{
    protected decimal balance = 0;

    bool virtual WithdrawFund(decimal amount){
        if(balance < amount)
        {
            return false
        }    
        balance = balance - amount;
        return true;
    }

    void PayInFund(decimal amount){
        balance = balance + amount;
    }

    decimal GetBalance(){
        return balance;
    }

    public abstract string RudeStringLetter();
}