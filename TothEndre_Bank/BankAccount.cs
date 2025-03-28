using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TothEndre_Bank
{
	internal abstract class BankAccount : BankingService
	{
		double balance;

		public double Balance { get; protected set; }
		protected BankAccount(Owner owner) : base(owner) 
		{
		
		}

		public void Deposit(double amount)
		{
			balance += amount;
		}

		public abstract bool Withdraw(double amount);

		public BankCard NewCard(string cardNumber)
		{
			return new BankCard(Owner, Balance, cardNumber);
		}
	}
}
