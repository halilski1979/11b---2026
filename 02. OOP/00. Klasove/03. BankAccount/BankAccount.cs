using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._BankAccount
{
    public class BankAccount
    {
		private int id;
        private double balance;

        public BankAccount(int id, double balance)
        {
            this.ID = id;
            this.Balance = balance;
            Console.WriteLine($"Sazdaden e bankov akaunt {this.ID} s smetka {this.Balance}");
        }

		public BankAccount()
		{

		}

        public int ID
		{
			get { return id; }
			set 
			{ 
				if (value<=0)
				{
                    throw new ArgumentException("Ne moje da ima smetka <=0");
                }
                id = value;
            }
            
        }	
		public double Balance
		{
			get { return balance; }
			set 
			{ 
				if (value <= 0)
				{				
                        throw new ArgumentException("Nqma otricatelen balance");         
									
                }
                balance = value;
            }
		}


		public override string ToString()
		{
			return $"ID:{this.ID} => Balance={this.Balance}";
		}
		public void Deposit(double amount)
		{
			Balance += amount;
		}
		public void Withdraw(double amount)
		{
            if (Balance<amount)
            {
                Console.WriteLine("Balansa po smetkata e nedostatachen.");
            }
            Balance -= amount;
		}
		public void PercentIncrease(double percent) 
		{
           Balance += Balance * (percent/100);
		}
		public void Print()
		{
            Console.WriteLine($"ID {this.ID} = {this.Balance}");
		}
	}
}
