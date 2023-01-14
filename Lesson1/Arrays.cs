namespace CustomArray;

public class Array
{
    // Private section
    private int[] _container;
    private uint _count;

    private void Resize()
    {
        int[] newContainer = new int[_container.Length * 2];
        for (int i = 0; i < _count; ++i)
        {
            newContainer[i] = _container[i];
        }

        _container = newContainer;
    }

    // Constructors
    public Array()
    {
        _container = new int[1];
        _count = 0;
    }

    public Array(uint len)
    {
        _container = new int[len];
        _count = 0;
    }

    public Array(int[] container)
    {
        _container = container;
        _count = (uint) container.Length;
    }

    public uint Length
    {
        get
        {
            return _count;
        }
    }

    public void Insert(int value, uint position)
    {
        if (_count + 1 > _container.Length)
        {
            Resize();
        }

        if (position > _count)
        {
            throw new Exception("Index out of range");
        }

        for (uint i = _count; i >= position; --i)
        {
            _container[i + 1] = _container[i];
        }

        _container[position] = value;
        _count++;
    }

    public void Remove(uint position)
    {
        
    }

    public override string ToString()
    {
        return base.ToString();
    }
}