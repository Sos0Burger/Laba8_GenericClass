internal class Program
{
    private static void Main(string[] args)
    {
        GenericArray<int> intArray = new GenericArray<int>(1,2,3);
        GenericArray<string> stringArray = new GenericArray<string>("Hello", "World");
        GenericArray<double> doubleArray = new GenericArray<double>(1.2, 100.134, 23.014143);

        intArray.print();
        stringArray.print();
        doubleArray.print();

    }
}
class GenericArray<T>
{
    T[] array;

    public GenericArray(params T[] mass)
    {
        array = mass;
    }

    public void add(T item)
    {
        T[] newArray = new T[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        newArray[array.Length] = item;
        array = newArray;
    }
    public void delete(T item)
    {
        T[] newArray = new T[array.Length - 1];
        int j = -1;
        bool wasDeleted = false;
        for (int i = 0; i < array.Length; i++)
        {
            j++;
            if (array[i].Equals(item)&& !wasDeleted)
            {
                wasDeleted = true;
                j--;
                continue;
            }
            newArray[j] = array[i];
        }
        array = newArray;
    }
    public void print()
    {
        foreach (var item in array)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }

    public T get(int index) {
        return array[index];
    }
    public int getLength()
    {
        return array.Length;
    }
}