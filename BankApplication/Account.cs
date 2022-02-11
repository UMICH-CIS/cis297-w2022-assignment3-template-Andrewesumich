using System;

public class Account : Object
{
	private decimal totalBalance;
	public Account(decimal initialBalance)
	{
		if (initialBalance < 0)
		{
			throw new Exception("The initial balance of an account cannot be negative");//calls an exception if the initial balance is negative
		}
		totalBalance = initialBalance;
	}
	public virtual bool credit(decimal deposit)
	{
		if(deposit < 0)//if negative dont deposit
		{
			Console.WriteLine("Amount deposited cannot be negative");
			return false;
        }
		totalBalance = totalBalance + deposit;
		return true;
	}
	public virtual bool debit(decimal withdraw)
	{
		if(withdraw < 0)//if negative dont withdraw
		{
			Console.WriteLine("Amount withdrawn cannot be negative");
			return false;
        }
		if (withdraw > totalBalance)//if the amount that is atempting to be withdrawn is more than is in the acount print a message and dont withdraw
		{
			Console.WriteLine("Debit amount exceeds acount balance");
			return false;
		}
		totalBalance = totalBalance - withdraw;//otherwise withdraw successfuly
		return true;
	}
	public decimal retriveBalance()//gets the current account balance
	{
		return totalBalance;
	}
}
