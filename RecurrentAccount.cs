using System;
class RecurrentAccount :IBankAccount
{
    private  int Accnt_no;
    private String Accnt_name;
    private int amount;

    //Deposit method
    public  void  Deposit(int a){
        amount = amount + a ;
        Console.WriteLine("{0} is Deposited Successfully " ,a);

    }
    //Withdraw Method
    public void  Withdraw(int a){
        if(a<amount)
            {   amount = amount  - a ;
                Console.WriteLine("{0} is  successfully withdrawed", a);
            }
        else
            {
            Console.WriteLine("Insufficient Balance");

             }

    }
    //Balance Checking Method
   public  void  Balance(){
        Console.WriteLine("Balance in Your Account :" + amount) ;
    }
    //Collecting Bank Details
   public void enterDetails (){
        String Continue ;
         int amnt;
         Console.WriteLine("Enter your Account number:");
         Accnt_no = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter your Account name:");
         Accnt_name = Console.ReadLine();
         Console.WriteLine("Welcome {0}To Your Recurrent Deposit bank account",Accnt_name);
         
         //Selecting Operations

         do{
          Console.WriteLine("Which Type of operation do You want to perform 1.Deposit 2.Withdraw 3.Balance");
          int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt) 
                    {
                    case 1:
                         Console.WriteLine("Enter your Amount");
                         amnt = Convert.ToInt32(Console.ReadLine());
                         Deposit(amnt);
                         break;
                    case 2:
                        Console.WriteLine("Enter your Amount");
                         amnt = Convert.ToInt32(Console.ReadLine());
                         Withdraw(amnt);
                        break;
                    case 3:
                        Balance();
                        break;
                   
                    }
                    Console.Write("Do You Want To Continue? (Y/N) : ");
                    Continue = Console.ReadLine();
         }     while (Continue != "N" && Continue != "n");

         Console.WriteLine("ThankYou");

    }
}