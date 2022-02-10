using System;

public class Account : Object
{
	private decimal totalBalance;
	public Account(decimal initialBalance)
	{
		if (initialBalance < 0)
		{
			Console.WriteLine("Error account blance must be greater than 0.0");
			totalBalance = 0;
			return;
		}
		totalBalance = initialBalance;
	}
	public virtual bool credit(decimal deposit)
	{
		totalBalance = totalBalance + deposit;
		return true;
	}
	public virtual bool debit(decimal withdraw)
	{
		if (withdraw > totalBalance)
		{
			Console.WriteLine("Debit amount exceeds acount balance");
			return false;
		}
		totalBalance = totalBalance - withdraw;
		return true;
	}
	public decimal retriveBalance()
	{
		return totalBalance;
	}
}
