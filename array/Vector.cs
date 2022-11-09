



public class Vector<T>
{
    public Vector() // <-- Constructor
    {
        _capacity = 1;
        _current = 0;
        vector = new T[_capacity];
    }

    // capacity() - number of items it can hold
    private ulong _capacity;
    public ulong Capacity { get => _capacity; }
    // size() - number of items
    private ulong _current;
    public ulong Size { get => _current; }

    public T[] vector;

    // Function to add an element at the last at the end
    public void push(T data)
    {
        // if the number of elements is equal to the capacity, that means we don't
        // have space to accommodate more elements. We need to double the capacity
        if (_current == _capacity)
        {
            ulong new_capacity = 2 * _capacity;
            var temp = new T[new_capacity];
            // copying old array elements to new array
            for (ulong i = 0; i < _capacity; i++) {
                temp[i] = vector[i];
            }
            vector = new T[new_capacity];
            for (ulong i = 0; i < new_capacity; i++) {
                vector[i] = temp[i];
            }
            _capacity = new_capacity;
        }
        // Insert data into the last element
        vector[_current] = data;
        _current++;
    }




    







}
