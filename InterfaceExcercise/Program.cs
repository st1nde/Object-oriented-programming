using InterfaceExcercise;


internal class Program
{
    private static void Main(string[] args)
    {
        //product p1 = new product("potato", 1.50, 33);
        //console.write(p1.tostring());
        List<Product> products = new List<Product>()
        {
            new Product("potato", 1.50, 3),
            new Product("Carrot", 2.00, 10),
            new Product("cabbage", 1.35, 4),
            new Product("tomato", 0.95, 8)
        };

        foreach (Product p in products)
        {
            Console.WriteLine(p.ToString());

            if (p.GetProduct("cabbage") != null)
            {
                Console.WriteLine("\nCabbage found");
                Console.Write("\nStorage value " + p.CalculateTotal() + "e\n\n");
            }

        }

        Console.WriteLine("Store");

        Store store1 = new Store("GroceryStore", 150000);
        store1.AddProduct(new Product("potato", 1.50, 3));
        store1.AddProduct(new Product("Carrot", 2.00, 10));


        List<Customer> customers = new List<Customer>()
        {   new Customer("Masa", 1200),
            new Customer("Mosa", 500),
            new Customer("Mesa", 12345)
        };

        for (int i = 0; i < 3; i++) 
        {

            Console.WriteLine(customers[i].GetCustomer(customers[i].name) + "\n");
            Console.WriteLine(customers[i].GetBonus());
        }

        store1.PrintCustomers();
        store1.PrintProducts();

    }
}