namespace Exercises.Items
{
    public class OOPProj06 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  - EXERCISE 4-6: Product";
        class Product
        {
            private string _name;
            private double _price;
            private int _quantity;

            public Product(string name, double price, int quantity)
            {
                _name = name;
                _price = price;
                _quantity = quantity;
            }

            public void PrintProduct()
            {
                Console.WriteLine($"{_name}: price {_price}: {_quantity} pcs");
            }
        }


        public override void Run()
        {

            Product bananaProduct = new Product("Banana", 1.1, 13);

            bananaProduct.PrintProduct();

        }
    }
}
