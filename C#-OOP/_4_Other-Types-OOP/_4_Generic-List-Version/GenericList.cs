using System;
using System.Linq;
using System.Text;

[Version(1, 2)]

public class GenericList<T> where T : IComparable<T>
{
    public const int DefaultCapacity = 16;
    private int capacity = 16;

    private int count = 0;
    private T[] elements;

    public GenericList(int capacity = DefaultCapacity)
    {
        this.elements = new T[DefaultCapacity];
    }

    public int Count
    {
        get { return this.count; }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }

            T result = this.elements[index];
            return result;
        }
    }

    public bool Add(T element)
    {
        if (this.count >= this.elements.Length)
        {
            this.EnsureResize();
        }

        this.elements[this.count] = element;
        this.count++;
        return true;
    }

    public bool Remove(int index)
    {
        if (index < 0 || index >= this.count)
        {
            throw new IndexOutOfRangeException("Invalid index.");
        }

        T[] newArr = new T[this.elements.Length - 1];

        Array.Copy(this.elements, 0, newArr, 0, index);
        Array.Copy(this.elements, index + 1, newArr, index, this.elements.Length - index - 1);

        this.elements = newArr;
        this.count--;
        return true;
    }

    public bool Insert(T element, int index)
    {
        if (index < 0 || index > this.Count)
        {
            throw new IndexOutOfRangeException("Invalid index.");
        }

        if (index == this.Count)
        {
            this.EnsureResize();
        }

        T[] newArr = new T[this.capacity];
        Array.Copy(this.elements, 0, newArr, 0, index);
        newArr[index] = element;
        Array.Copy(this.elements, index, newArr, index + 1, this.capacity - index - 1);
        this.elements = newArr;
        this.count++;
        return true;
    }

    public void Clear()
    {
        this.elements = new T[DefaultCapacity];
        this.count = 0;
    }

    public int FindIndexByValue(T value)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.elements[i].CompareTo(value) == 0)
            {
                return i;
            }
        }

        return -1;
    }

    public bool Contains(T value)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.elements[i].CompareTo(value) == 0)
            {
                return true;
            }
        }

        return false;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < this.Count - 1; i++)
        {
            sb.Append(string.Format("{0} ", this.elements[i]));
        }

        sb.Append(this.elements[this.Count - 1]);
        return sb.ToString();
    }

    public T Min()
    {
        T min = this.elements[0];
        for (int i = 0; i < this.Count; i++)
        {
            if (min.CompareTo(this.elements[i]) >= 0)
            {
                min = this.elements[i];
            }
        }

        return min;
    }

    public T Max()
    {
        T max = this.elements[0];
        for (int i = 0; i < this.Count; i++)
        {
            if (max.CompareTo(this.elements[i]) <= 0)
            {
                max = this.elements[i];
            }
        }

        return max;
    }

    private void EnsureResize()
    {
        if (this.Count + 1 > this.capacity)
        {
            this.capacity *= 2;
            T[] extended = new T[this.capacity];
            Array.Copy(this.elements, 0, extended, 0, this.elements.Length);
            this.elements = extended;
        }
    }
}