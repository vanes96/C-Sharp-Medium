namespace Task3._2
{
    public class Product
    {
        public int Id { get; }
        public string Name { get;}
        public int Price { get; }
        public int Quantity { get; }

        public Product(int id, string name, int price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
