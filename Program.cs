using System;

namespace Interface_Demo
{
    class Program
    {
        static void Main(string[] args)
        {   
            //choosing the account type
            Console.WriteLine("Which Type of account You have 1.Savings 2.Current 3.recurrent Savings");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option) 
                    {
                    case 1:
                        savingsAccount saveaccount = new savingsAccount();
                        saveaccount.enterDetails();
                        break;
                    case 2:
                        currentAccount currentaccount = new currentAccount();
                        currentaccount.enterDetails();
                        break;
                    case 3:
                        RecurrentAccount recurrentaccount = new RecurrentAccount();
                        recurrentaccount.enterDetails();
                        break;
                   
                    }
                   
         }
    }
                
}
