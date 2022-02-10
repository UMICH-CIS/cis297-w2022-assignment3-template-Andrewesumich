using System;

public class checkingAccount : Account
{
	decimal transactionFee;
	public checkingAccount(decimal initialBalance, decimal initialFee) : base(initialBalance)
	{
		if(initialFee < 0)
        {
			Console.WriteLine("Error transaction fee must be greater than 0.0");
			transactionFee = 0;
			return;
		}
		transactionFee = initialFee;
	}
	public override bool credit(decimal deposit)
    {
		if(base.credit(deposit))
        {
			base.debit(transactionFee);
        }
		return true;
    }

    public override bool debit(decimal withdraw)
    {
		if(base.debit(withdraw))
        {
			base.debit(transactionFee);
			return true;
		}
		return false;
    }
}
