public interface IAccount{
    bool WithdrawFund(decimal amount);
    void PayInFund(decimal amount);
    decimal GetBalance();
    string RudeStringLetter();
}