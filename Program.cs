using System;
using System.Collection.Generics;

namespance Banking
{
    public class Account{
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