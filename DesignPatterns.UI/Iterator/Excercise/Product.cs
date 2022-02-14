namespace DesignPatterns.UI.Iterator.Excercise
{
    public class Product
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;

        public Product(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}