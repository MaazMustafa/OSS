using System;
using System.Collection.Generics;

namespance Banking
{
public Class Account{
    public double Balance {get;set;}
    public Account(double amount){
        this.Balance=amount;
    }
    public void Deposit(double amount){
        this.Balance+=amount;

    }

     public void Withdrraw(double amount){
        this.Balance-=amount;
        
    }
}

}