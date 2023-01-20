namespace CustomArray;

public class Array
{
    // Private section
    private int[] _container;
    private uint _count;
    private bool _is_sorted = false;

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
        if (position < _count)
        {
            throw new Exception("Index out of range");
        }
        
        for (uint i = position; i < _count - 1; i++)
        { 
            _container[i] = _container[i + 1];
        }

        _count--;
    }

    public int this[uint index]
    {
        get
        {
            if (index >= _count)
            {
                throw new IndexOutOfRangeException();
            }

            return _container[index];
        }
        
        set
        {
            Insert(value, index);
        }
    }

    public uint LinearSearch(int value) 
    { 
        for (uint i = 0; i < _count; i++) 
        { 
            if (value == _container[i]) 
            { 
                return i; 
            } 
        } 
        
        throw new Exception("Incorret value"); 
    }

    void Sort()
    {
        // Your Sort here!
    }

    public uint BinarySearchIter(int value)
    {
        uint start = 0;
        uint end = _count;
        uint mid;

        if (!_is_sorted)
        {
            Sort();
        }

        while (start <= end)
        {
            mid = (start + end) / 2;

            if (_container[mid] == value)
            {
                return mid;
            }

            if (value > _container[mid])
            {
                start = mid + 1;
            }

            if (value < _container[mid])
            {
                end = mid - 1;
            }
        }

        throw new Exception("No such value");
    }

    public uint BinarySearch(int value)
    {
        if (!_is_sorted)
            Sort();
        return BinarySearch(value, 0, _count);
    }
    private uint BinarySearch(int value, uint start, uint end)
    {
        uint mid = (start + end) / 2;

        if (start > end)
            throw new Exception("No such value");

        if (_container[mid] == value)
            return mid;

        if (_container[mid] > value)
            return BinarySearch(value, start, mid - 1);
        else
            return BinarySearch(value, mid + 1, end);
    }

    public override string ToString()
    {
        string buf = "[";
        for (int i = 0; i < _count - 1; ++i)
        {
            buf += _container[i] + ", ";
        }

        buf += _container[_count - 1] + "]";
        return buf;
    }
}