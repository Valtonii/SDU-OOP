class Test
{
    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory(new Item[0]);

        FoodItem apple = new FoodItem("Apple", 10, new DateTime(2026, 12, 1));
        NonFoodItem pc = new NonFoodItem("PC", 200, new string[] { "steel, ", "plastic, ", "PC components" });

        inventory.AddItem(apple);
        inventory.AddItem(pc);

        inventory.PrintInventory();
        Console.WriteLine("Total: " + inventory.GetInventoryValue());
        Console.WriteLine();
        inventory.PrintExpiryStatus();


    }
}

abstract class Item : IExpirable
{
    private string name;
    private double price;

    public Item(string nameValue, double priceValue)
    {
        name = nameValue;
        price = priceValue;
    }

    public string GetName()
    {
        return name;
    }
    public double GetPrice()
    {
        return price;
    }

    public abstract bool IsExpired();
}

class Inventory
{
    private Item[] items;

    public Inventory(Item[] items)
    {
        this.items = items;
    }

    public void AddItem(Item item) {
        Item[] itemList = new Item[items.Length + 1];
        for (int i = 0; i < items.Length; i++)
        {
            itemList[i] = items[i];
        }
        itemList[items.Length] = item;
        items = itemList;
    }

    public void RemoveItem(Item item) {
        int index = -1;
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                index = i;
                break;
            }
        }
        if (index == -1)
        {
            return;
        }
        Item[] itemList = new Item[items.Length - 1];
        for (int i = 0; i < items.Length; i++)
        {
            if (i < index)
            {
                itemList[i] = items[i];
            }
            else if (i > index)
            {
                itemList[i - 1] = items[i];
            }
        }
        items = itemList;
    }

    public double GetInventoryValue()
    {
        double sum = 0;
        for (int i = 0; i < items.Length; i++)
        {
            sum += items[i].GetPrice();
        }
        return sum;
    }

    public void PrintExpiryStatus()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].IsExpired())
            {
                Console.WriteLine(items[i].GetName() + " is expired.");
            }
            else
            {
                Console.WriteLine(items[i].GetName() + " is not expired.");
            }
        }
    }

    public void PrintInventory() {
        for(int i = 0;i<items.Length;i++){
        Console.WriteLine(items[i]);
        }
    }

}

class FoodItem : Item
{
    private DateTime expiresAt;

    public FoodItem(string nameValue, double priceValue, DateTime expiresAtDate)
    : base(nameValue, priceValue)
    {
        expiresAt = expiresAtDate;
    }

    public DateTime GetExpiresAt()
    {
        return expiresAt;
    }
    public override string ToString()
    {
        return "Name: " + GetName() + ", price: " + GetPrice() + " and expiration date: " + GetExpiresAt();
    }

    public override bool IsExpired()
    {
        return DateTime.Now > expiresAt;
    }
}

class NonFoodItem : Item
{
    private string[] materials;

    public NonFoodItem(string nameValue, double priceValue, string[] materialsValue)
    : base(nameValue, priceValue)
    {
        materials = materialsValue;
    }

    public string[] GetMaterials()
    {
        return materials;
    }

    public override string ToString()
    {
        string materialsText = "";

        for (int i = 0; i < materials.Length; i++)
        {
            materialsText += materials[i];
        }
        return "Name: " + GetName() + ", price: " + GetPrice() + " and the list of materials: " + materialsText;
    }

    public override bool IsExpired(){
        return false;
    }
}

public interface IExpirable {
     bool IsExpired();
}

/*
TAKEAWAY OF THIS EXERCISE: Four things.

You can’t make an Item any more. The class exists as a type, holds the shared fields, and the compiler
rejects new Item(...) before the program ever runs. A category that can’t be mistaken for a thing.

An interface states an ability separately from the family tree. IExpirable says “can answer whether it’s expired”
and says nothing about what the thing is. A coupon or a subscription could implement it tomorrow without touching your class hierarchy.

The abstract method is the bridge between those two. Item takes on the interface’s obligation and immediately pushes
it down with public abstract bool IsExpired();. It promises the ability exists without knowing how it works.
Every concrete subclass is then forced to write one, and the compiler checks it: forget it in FoodItem and nothing builds.

And the cost, which is the part worth being able to argue. NonFoodItem had to write return false;, a method that ignores all its data.
That’s what happens when you attach an ability to a parent: every child inherits the obligation whether it fits or not. The alternative,
putting IExpirable only on FoodItem, means Inventory can no longer ask the whole array, and you’re back to type-checking. Neither is free.
*/
