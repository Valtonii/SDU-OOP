IDynArray<int> a = new DynArray<int>();
Console.WriteLine("Add elements:");
Console.WriteLine(a);

for (int i = 0; i < 20; i++)
{
    a.Append(i);
    Console.WriteLine(a);
}
Console.WriteLine("");

Random random = new Random();
Console.WriteLine("Remove elements:");
Console.WriteLine(a);

for (int i = 19; i >= 0; i--)
{
    a.Remove(random.Next(a.GetFill()));
    Console.WriteLine(a);
}



class DynArray<T> : IDynArray<T>{
    T[] data;
    int capacity;
    int fill;

    public DynArray()
    {
        data = new T[10];
        capacity = data.Length;
        fill = 0;
    }

    public T Get(int i)
    {
        return data[i];
    }

    public void Set(int i, T element)
    {
        data[i] = element;
    }

    public int GetFill()
    {
        return fill;
    }

    public void Append(T element)
    {
        if (fill == capacity){
            Grow();
        }
        data[fill] = element;
        fill++;
    }

    private void Grow()
    {
        T[] dataDouble = new T[data.Length * 2];
        for (int i = 0; i < data.Length; i++)
        {
            dataDouble[i] = data[i];
        }
        data = dataDouble;
        capacity = dataDouble.Length;
    }

    private void Shrink()
    {
        T[] dataHalf = new T[capacity / 2];
        for (int i = 0; i < fill; i++)
        {
            dataHalf[i] = data[i];
        }
        data = dataHalf;
        capacity = data.Length;
    }

    public void Insert(int i, T element)
    {
        if (fill == capacity)
        {
            Grow();
        }
        for (int j = fill - 1; j >= i; j--)
        {
            data[j + 1] = data[j];
        }
        data[i] = element;
        fill++;
    }

    public override string ToString()
    {
        string dataText = "";

        for (int i = 0; i < fill; i++)
        {
            if (i > 0) { dataText += ","; }
            dataText += data[i];
        }
        return "[" + dataText + "] fill=" + fill + " cap=" + capacity;
    }

    public void Remove(int i) {
        for (int j = i; j < fill-1; j++)
        {
            data[j] = data[j+1];
        }
        fill--;
        if (fill < capacity / 2 && capacity > 10)
        {
            Shrink();
        }

    }
}

interface IDynArray<T>
{
    void Append(T element);
    void Insert(int i, T element);
    void Remove(int i);
    void Set(int i, T element);
    T Get(int i);
    int GetFill();
}

/* TAKE AWAYS FROM THIS EXERCISE:
You wrote it once and it works for any type. The test used DynArray<int>,
but DynArray<FoodItem> would compile and run with no changes.
Part 0’s problem, solved.

You’ve just built List<T>. That’s what .NET’s List is underneath:
an array, a fill count, and automatic resizing.

Every language has one. Now you know what’s happening when you add to it.

And the part worth comparing to last week. Your Inventory.AddItem grew the array
by exactly one slot every single time, copying everything on every add. This one doubles.
Add 1000 items and Inventory does 1000 copies of the whole array; DynArray does about 10.
Same problem, and the growth strategy is the entire difference.
That’s why the exercise specifies doubling and halving rather than plus-one and minus-one.

*/
