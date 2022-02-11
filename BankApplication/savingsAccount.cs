using System;

public class savingsAccount : Account
{
	decimal interestRate;
	public savingsAccount(decimal initialBalance, decimal initialRate) : base(initialBalance)
	{
		if(initialRate < 0)//if the interest rate is initialized as negative throw an exception
        {
			throw new Exception("the interest rate of an account cannot be negative");
		}
		interestRate = initialRate;
	}
	public decimal calculateInterest()//calculates interest
	{
		return retriveBalance() * interestRate;
	}
}
