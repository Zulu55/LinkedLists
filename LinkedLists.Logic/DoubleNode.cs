namespace LinkedLists.Logic
{
    public class DoubleNode<T>
    {
        public T? Data { get; set; }

        public DoubleNode<T>? Left { get; set; }

        public DoubleNode<T>? Right { get; set; }

        public DoubleNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
