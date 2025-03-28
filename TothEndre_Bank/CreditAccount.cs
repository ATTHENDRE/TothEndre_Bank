using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TothEndre_Bank
{
	internal class CreditAccount : BankAccount
	{
		double creditLimit;


		public double CreditLimit { get => creditLimit; }
		public CreditAccount(Owner owner, double creditLimit) : base(owner)
		{
			this.creditLimit = creditLimit;
		}

		public override bool Withdraw(double amount)
		{
			if(this.Balance - amount >= creditLimit)
			{
				this.Balance -= amount;
				return true;
			}
			return false;
		}
	}
}
