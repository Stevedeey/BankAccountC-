public class BabyAccount : Account{
      
    public override bool WithdrawFund(decimal amount){
        if(amount > 10){
            return false;
        }
        return base.WithdrawFund(amount);
    }
    
    public override string RudeStringLetter(){
        return "Tell daddy your are overdrawn";
    }
}