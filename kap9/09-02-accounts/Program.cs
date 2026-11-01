int[] accounts = {903, 716, 67};
int GetAccountNumber ()
{
        Console.WriteLine("Enter an account number: ");
        return Convert.ToInt32(Console.ReadLine());
}

void PrintAccountState (int accountId)
{
    Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

while (true)
{
    try
    {
        int accountId = GetAccountNumber();
        PrintAccountState(accountId);
    }
    catch (IndexOutOfRangeException) {
        Console.WriteLine("noob");
    }
    catch (FormatException) {
        Console.WriteLine("Newbie");
    }

}
/*
GetAccountNumber detects the bad input but cannot handle it. Its return type is int, and there is no int that means “the user typed nonsense”,
so it has no way to report failure through its return value. It also can’t recover on its own.

The while loop can. When a catch block finishes there, the loop goes round and prompts again.
So detection happens in the callee and handling happens in the caller, which is the separation the exception mechanism exists for.
*/
