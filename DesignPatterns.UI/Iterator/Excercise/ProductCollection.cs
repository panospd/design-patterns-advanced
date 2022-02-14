namespace DesignPatterns.UI.Iterator.Excercise
{
    public class ProductCollection
    {
        public List<Product> Products { get; } = new();

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public Iterator<Product> CreateIterator()
        {
            return new ProductIterator(this);
        }

        public class ProductIterator : Iterator<Product>
        {
            private readonly ProductCollection _collection;
            private int _index;

            public ProductIterator(ProductCollection collection)
            {
                _collection = collection;
            }

            public Product Curent()
            {
                return _collection.Products[_index];
            }

            public bool HasNext()
            {
                return _index < _collection.Products.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}