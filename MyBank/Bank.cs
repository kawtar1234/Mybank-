namespace banking{
using System;
using System.Collections;

public class Bank{

    private string name;
    private ArrayList accounts;

    public Bank(string newName){
        setName(newName);
        accounts = new ArrayList();
    }

    public void addAccount(Account newAccount){
        setAccounts(newAccount);
    }

    public void removeAccount(int id){
        if(id >= accounts.Count){
            Console.WriteLine("Out of index");
        }
        else{
            accounts.RemoveAt(id);
        }
        
    }

    public void setAccounts(Account newAccount){
        accounts.Add(newAccount);
    }

    public ArrayList getAccounts(){
        return accounts;
    }

    public string getName(){
        return name;
    }

    public void setName(string newName){
        name = newName;
    }

    
}
}
