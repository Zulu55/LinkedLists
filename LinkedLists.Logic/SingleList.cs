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
    }
}
