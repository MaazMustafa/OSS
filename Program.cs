using System;
using System.Collection.Generics;

namespance Banking
{
    public delegate void AccountOperation();

    public class Account{

        public event AccountOperation overBalance;
        public event AccountOperation underBalance;

        public double Balance {get;set;}
        public Account(double amount){
            this.Balance=amount;
            if(this.Balance <=5000){
                underBalance();
            }
            else if(this.Balance>=250000){
                overBalance();
            }
        }
        public void Deposit(double amount){
            this.Balance+=amount;
             if(this.Balance <=5000){
                underBalance();
            }
            else if(this.Balance>=250000){
                overBalance();
            }

        }

            public void Withdrraw(double amount){
            this.Balance-=amount;
             if(this.Balance <=5000){
                underBalance();
            }
            else if(this.Balance>=250000){
                overBalance();
            }
        
        }
    }


    public class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Hello Banking Application");
        Console.WriteLine("Welcome from Maaz");
        Console.WriteLine("Online Shopping Application Portal");
        }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeNazme { get; set; }
        public string SME { get;set }

    }

}