using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
           BankA firstbank = new BankA();
        //    firstbank.getBalance();
           BankB gtbank = new BankB();
        //    gtbank.getBalance();
           BankC unionbank= new BankC();
        //    unionbank.getBalance();

            var firstBankBal = firstbank.getBalance();
            var gtBankBal = gtbank.getBalance();
            var unionBankBal = unionbank.getBalance();

            Console.WriteLine("your balance in firstbank is " +"$" + firstBankBal);
             Console.WriteLine("your balance in gtbank  is "+"$" + gtBankBal);
              Console.WriteLine("your balance in uniontbank  is "+"$" + unionBankBal);
        }
    }

    public abstract class Bank
    {
       public abstract decimal  getBalance();
    }

    public class BankA :Bank
    {
        decimal bal = 100.00M;
        public override decimal getBalance()
        {
          
        return bal;
        }


    }
    public class BankB :Bank
    {
        decimal bal = 150.00M;
        public override decimal getBalance()
        {
          return bal;
        }

        
    }
    public class BankC: Bank
    {
        decimal bal = 200.00M;
        public override decimal getBalance()
        {
        return bal;
        }

        
    }
}
