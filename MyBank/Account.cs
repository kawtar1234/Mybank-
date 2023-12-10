namespace banking{
using System;

public class Account {

    private Double Balance;
    private string AccountName;
    

    public Account(string newAccountName){
        setAccountName(newAccountName);
        setBalance(0);
    }

    public Account(string newAccountName,Double newBalance){
       setAccountName(newAccountName);

        if(newBalance > 0){
             setBalance(newBalance);
        }
        else{
            Balance = 0;
        }
       
    }

    
    public void Deposite(Double solde){

        if(solde > 0){
            Balance = Balance + solde;
            Console.WriteLine(getAccountName() + " Your new Balance is:" + getBalance());
        }

        else{
            Console.WriteLine("solde should be > 0");
        }
    }


    public void Withdraw(Double solde){
        if(solde < 0){
            Console.WriteLine("solde should be > 0");
        }
        else{
            if(solde > Balance){
                Console.WriteLine("Balance is insufficient");
            }
            else{
                Balance = Balance - solde;
                Console.WriteLine(getAccountName() + " Your new Balance is:" + getBalance());
            }
        }
    }

    public Double getBalance(){
        return Balance;
    }

    public void setBalance(Double newBalance){
        Balance = newBalance;
    }

    public string getAccountName(){
        return AccountName;
    }

    public void setAccountName(string newAccountName){
        AccountName = newAccountName;
    }

    public override string ToString()
        {
            return $"Account Name: {AccountName}, Balance: {Balance}";
        }

}

}

