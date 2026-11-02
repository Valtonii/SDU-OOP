Customer aCustomer = new Customer("Valton", 1, 1000);
Customer aCustomer2 = new Customer("Elias", 2, 1000);
Customer aCustomer3 = new Customer("Anel", 3, 1000);
CustomerDatabase customerList = new CustomerDatabase();

customerList.Add(aCustomer);
customerList.Add(aCustomer2);
customerList.Add(aCustomer3);

for (int i = 4; i <= 10; i++)
{
    customerList.Add(new Customer("Customer", i, 0));
}

Console.WriteLine(customerList.Add(new Customer("Bleh", 11, 0)));

aCustomer.Deposit(100);
aCustomer.Withdraw(50);
// Test to see if balance arithmetic works: Console.WriteLine(aCustomer.GetBalance());

customerList.PrintCustomers();

class Customer
{
    public string name;
    public int id;
    public double balance;

    public Customer(string nameValue, int idValue)
    {
        name = nameValue;
        id = idValue;
        balance = 0;
    }

    public Customer(string nameValue, int idValue, double balanceValue)
    {
        name = nameValue;
        id = idValue;
        balance = balanceValue;
    }

    public override string ToString()
    {
        return "Customer " + id + ": " + name + ", balance: " + balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }
    public double GetBalance()
    {
        return balance;
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance = balance - amount;
        }
    }
}

class CustomerDatabase
{
    public Customer[] customers;

    public CustomerDatabase()
    {
        customers = new Customer[10];
    }
    public bool Add(Customer customer)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i] == null)
            {
                customers[i] = customer;
                return true;
            }
        }
        return false;
    }
    public void Remove(int id)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i] != null && id == customers[i].id)
            {
                customers[i] = null;
                return; // job done, no point checking the rest
            }
        }
    }
    public Customer[] GetCustomers()
    {
        return customers;
    }
    public void PrintCustomers(){
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i] != null)
            {
                Console.WriteLine(customers[i]);
            } else {
                Console.WriteLine("Empty slot");
            }
        }
    }
}

// NOT A BUG: (80,32): warning CS8625: Cannot convert null literal to non-nullable reference type.
