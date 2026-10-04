Account robsAccount = new Account();
robsAccount.Name = "Rob";
Console.WriteLine("1: " + robsAccount.Name);

Account sameAccount = robsAccount;
sameAccount.Name = "Valton";
Console.WriteLine("2: " + robsAccount.Name);

Account otherAccount = new Account();
otherAccount.Name = "David";
Console.WriteLine("3: " + robsAccount.Name);
Console.WriteLine("4: " + otherAccount.Name);



class Account { public string Name = ""; }
