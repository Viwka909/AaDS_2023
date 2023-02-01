namespace DynamicArray;

public class DArray : Array
{
    public DArray() {
        _container = new int[1];
        _count = 0;
    }

    public DArray(int count) {
        throw new NotImplementedException();
    }

    public DArray(int[] container) {
        throw new NotImplementedException();
    }

    public override int this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public override int Length
    {
        get => throw new NotImplementedException();
    }

    public override void Insert(int value, int position)
    {
        throw new NotImplementedException();
    }

    public override void Insert(int value)
    {
        throw new NotImplementedException();
    }

    public override void Remove(int index)
    {
        throw new NotImplementedException();
    }

    public override void Remove()
    {
        throw new NotImplementedException();
    }

    public override int BinarySearch(int value)
    {
        throw new NotImplementedException();
    }

    public override int LinearSearch(int value)
    {
        throw new NotImplementedException();
    }

    public override void Sort()
    {
        throw new NotImplementedException();
    }
}