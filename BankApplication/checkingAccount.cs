using System;

public class checkingAccount : Account
{
	decimal transactionFee;
	public checkingAccount(decimal initialBalance, decimal initialFee) : base(initialBalance)
	{
		if(initialFee < 0)//if the transaction fee is initialized as negative throw an exception
        {
			throw new Exception("the transaction fee of an account cannot be negative");
		}
		transactionFee = initialFee;
	}
	public override bool credit(decimal deposit)
    {
		if (deposit != 0)//if not depositing skip deposit fee
		{
			if (base.credit(deposit))//if a deposit is successful
			{
				if (retriveBalance() < transactionFee)//if the current balance is less than the transaction cost set the acount to zero
				{
					base.debit(retriveBalance());//set account total to zero
					return true;
				}
				base.debit(transactionFee);//take away the transaction fee
				return true;
			}
		}
		return false;
	}

    public override bool debit(decimal withdraw)
    {
		if (withdraw != 0)//if not withdrawing skip withdraw fee
		{
			if (base.debit(withdraw))//if a withdraw is successful
			{
				if (retriveBalance() < transactionFee)//if the current balance is less than the transaction cost set the acount to zero
				{
					base.debit(retriveBalance());//set account total to zero
					return true;
				}
				base.debit(transactionFee);//take away the transaction fee
				return true;
			}
		}
		return false;
    }
}
