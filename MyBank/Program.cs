namespace banking
{
using System;
using System.Collections;
class Program {
  static void Main() {

    
        Bank mybank = new Bank("myBank");
        Account account1 = new Account("kawtar",100);
        Account account2 = new Account("account2",150);
        Account account3 = new Account("account3",70);

        mybank.addAccount(account1);
        mybank.addAccount(account2);
        mybank.addAccount(account3);

        int choice = 0;
        string name;
        double balance;
        int id =0;


        while(choice != 999){
            Console.WriteLine("\n\n\n----------------------- Menu -----------------------\n");
            Console.WriteLine("1- Add Account: ");
            Console.WriteLine("2- View Accounts: ");
            Console.WriteLine("3- Remove Account: ");
            Console.WriteLine("4- exit.");
            Console.Write("Your Choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.Write("Enter the Account name :");
                    name = Console.ReadLine();
                    Console.Write("Enter the Balnce :");
                    balance = Convert.ToDouble(Console.ReadLine());
                    Account newaccount = new Account(name,balance);
                    mybank.addAccount(newaccount);
                    break;
                
                case 2:
                    for(int i = 0; i< mybank.getAccounts().Count; i++){
                        Console.WriteLine((i+1) + "- " + ((Account)mybank.getAccounts()[i]));
                    }
                    break;

                case 3:
                    Console.Write("Enter the account Id : ");
                    id =  Convert.ToInt32(Console.ReadLine());
                    mybank.removeAccount(id-1);
                    break;

                
                case 4:
                    choice = 999;
                    break;


                default:
                    break;
            }

        }
        


        

        
       
    
         
        
        
        
  }
 
}



    
}
