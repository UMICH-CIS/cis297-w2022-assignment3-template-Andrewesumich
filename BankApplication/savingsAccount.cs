using System;

public class savingsAccount : Account
{
	decimal interestRate;
	public savingsAccount(decimal initialBalance, decimal initialRate) : base(initialBalance)
	{
		if(initialRate < 0)
        {
			Console.WriteLine("Error interest rate must be greater than 0.0");
			interestRate = 0;
			return;
		}
		interestRate = initialRate;
	}
	public decimal calculateInterest()
	{
		return retriveBalance() * interestRate;
	}
}
