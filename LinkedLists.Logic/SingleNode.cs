namespace LinkedLists.Logic
{
    public class SingleNode<T>
    {
        public T Data { get; set; }

        public SingleNode<T>? Next { get; set; }

        public SingleNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
}