namespace YouTube.CSharp.Events
{    

    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            Stock = stock;
        }


        public event Action ProductControllerEvent;
        public string Name { get; set; }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (Stock < 18 && ProductControllerEvent != null)
                {
                    ProductControllerEvent();
                }
            }
        }


        public void Sell(int sell)
        {
            Stock = Stock - sell;
        }
    }
}
