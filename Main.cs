using System;
class HelloWorld {
  static void Main() {
   
    BabyAccount account = new BabyAccount();
    
    account.PayInFund(1048);
    
    Console.WriteLine("The balance:: "+ account.GetBalance());
    
   //PayInFund
    Console.WriteLine("How much do you want to Pay In? ");
    
    
    int amount = Convert.ToInt32(Console.ReadLine());
    
    account.PayInFund(amount);
    Console.WriteLine("The balance:: "+account.GetBalance());

    
    Console.WriteLine("How much do you want to withdraw? ");
    
    int amount2 = Convert.ToInt32(Console.ReadLine());
    
    bool withdraw = account.WithdrawFund(amount2);
    
    if(withdraw == false){

        Console.WriteLine("Something went wrong!");
        return;
    }
    
    Console.WriteLine("The balance:: "+account.GetBalance());
    
      
  }
}