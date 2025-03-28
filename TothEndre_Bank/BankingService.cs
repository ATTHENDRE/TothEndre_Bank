using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TothEndre_Bank
{
	internal abstract class BankingService
	{
		Owner owner;

		public Owner Owner { get; }

		public BankingService(Owner owner)
		{
			this.owner = owner;
		}
	}
}
