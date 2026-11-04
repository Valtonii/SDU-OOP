class Test
{
    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory(new Item[0]);

        FoodItem apple = new FoodItem("Apple",10, new DateTime(2026, 12, 1));
        NonFoodItem pc = new NonFoodItem("PC",200, new string[] {"steel, ", "plastic, ", "PC components"});

        inventory.AddItem(apple);
        inventory.AddItem(pc);

        inventory.PrintInventory();
        Console.WriteLine("Total: " + inventory.GetInventoryValue());
    }
}

class Item
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

    public double GetInventoryValue() {
        double sum = 0;
        for (int i = 0; i < items.Length; i++)
        {
            sum += items[i].GetPrice();
        }
        return sum;
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
}

/*
TAKE AWAY FROM THIS EXERCISE - Three things:

1. One array holds both types. Item[] accepts FoodItem and NonFoodItem because both are Items.
That’s why 13.1’s two arrays and two loops collapse into one of each.

2. Inventory never mentions FoodItem or NonFoodItem. Read it again: no if, no type check, no cast anywhere.
It only knows Item. Yet each object prints its own format and contributes its own price.
The actual type decides at runtime; Inventory never has to ask.

3. So adding a new subclass costs nothing. Write DigitalItem : Item tomorrow and Inventory works with it untouched.
That’s the payoff, and it’s why the exercise is in the polymorphism chapter.
*/
