FoodItem[] foodItems = new FoodItem[10];
for (int i = 0; i < foodItems.Length; i++)
{
    foodItems[i] = new FoodItem("Apple: " + i, 12.5, new DateTime(2026, 12, 1 + i));
}
Console.WriteLine("");
for (int i = 0; i<foodItems.Length; i++){
    Console.WriteLine(foodItems[i].ToString());
}
Console.WriteLine("");


NonFoodItem[] nonFoodItems = new NonFoodItem[10];
for (int i = 0; i < nonFoodItems.Length; i++)
{
    nonFoodItems[i] = new NonFoodItem("PC: " + i, 1250, new string[] {"steel, ", "plastic, ", "PC components"});
}
Console.WriteLine("");
for (int i = 0; i<nonFoodItems.Length; i++){
    Console.WriteLine(nonFoodItems[i].ToString());
}
Console.WriteLine("");

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

        for (int i = 0; i<materials.Length; i++){
            materialsText += materials[i];
        }
        return "Name: " + GetName() + ", price: " + GetPrice() + " and the list of materials: " + materialsText;
    }
}
