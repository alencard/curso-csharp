namespace _77Generics1.Entities
{
    internal class PrintService<T>
    {
        private readonly T[] _values = new T[10];
        private int _count = 0;

        public void AddValues(T value)
        {
            if (_count >= 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_values.Length == 0)
            {
                throw new InvalidOperationException("PrintService is Empty");
            }

            return _values[0];
        }

        public void Print()
        {
            int i = 0;

            Console.Write("[");

            while (i < _values.Length - 1)
            {
                Console.Write($"{_values[i]}, ");
                i++;
            }
            Console.Write(_values[^1]);

            Console.WriteLine("]");
        }
    }
}
