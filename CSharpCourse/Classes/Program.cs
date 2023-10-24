namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add();
            costumerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.ReadLine();
        }
    }
    /*
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }
        public void Update() 
        {
            Console.WriteLine("Product Updated!");
        }
    }
    
    class CostumerManager
    {
        public void Add()
        {
            Console.WriteLine("Costumer Added");
        }
        public void Update() 
        {
            Console.WriteLine("Costumer Updated!");
        }
    }*/
}