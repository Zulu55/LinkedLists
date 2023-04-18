namespace LinkedLists.Logic
{
    public class Fruit
    {
        public string? Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:C2}";
        }
    }
}
