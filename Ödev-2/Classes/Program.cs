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

            Costumer costumer = new Costumer();
            costumer.City = "Ankara";
            costumer.Id = 1;
            costumer.FirstName = "Mustafa";
            costumer.LastName = "Demirci";

            Costumer costumer2 = new Costumer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "mustafa",
                LastName = "demirci"
            };
            Console.WriteLine(costumer2.FirstName);
            Console.ReadLine();
        }
    }
}