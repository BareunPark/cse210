namespace OrderingSystem
{
    class Product
    {
        private string _name;
        private string _productID;
        private double _price;
        private int _quantity;
        public Product(string name, string productID, double price, int quantity)
        {
            _name = name;
            _productID = productID;
            _price = price;
            _quantity = quantity;
        }
        public double GetPrice()
        {
            return _price * _quantity;
        }
        public override string ToString()
        {
            return $"{_name} {_productID}";
        }
    }
}