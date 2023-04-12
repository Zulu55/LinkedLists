namespace LinkedLists.Logic
{
    public class SingleList<T>
    {
        private SingleNode<T>? _first;

        public SingleList()
        {
            _first = null;
        }

        public bool IsEmpty => _first == null;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Next;
            }
            return output;
        }

        public void Add(T item)
        {
            var node = new SingleNode<T>(item);
            if (IsEmpty)
            {
                _first = node;
            }
            else
            {
                var pointer = _first;
                while (pointer!.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = node;
            }
        }

        public bool Remove(T item)
        {
            var pointer = _first;
            var previous = pointer;
            while (pointer != null)
            {
                if (pointer.Data!.Equals(item))
                {
                    if (pointer == _first)
                    {
                        _first = pointer.Next;
                    }
                    else
                    {
                        previous!.Next = pointer.Next;
                    }

                    return true;
                }
                previous = pointer;
                pointer = pointer.Next;

            }
            return false;
        }

        public bool Insert(T current, T item)
        {
            var pointer = _first;
            var previous = pointer;
            while (pointer != null)
            {
                if (pointer.Data!.Equals(current))
                {
                    var node = new SingleNode<T>(item);

                    if (pointer == _first)
                    {
                        _first = node;
                        node.Next = pointer;
                    }
                    else
                    {
                        previous!.Next = node;
                        node.Next = pointer;
                    }

                    return true;
                }
                previous = pointer;
                pointer = pointer.Next;

            }
            return false;
        }
    }
}
