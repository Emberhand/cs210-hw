using System;

class Program
{
    static void Main(string[] args)
    {
        Product prod1 = new Product();
        prod1.SetName("Snake Oil");
        prod1.SetId("A1");
        prod1.SetPrice(100);
        prod1.SetQuantity(1);

        Product prod2 = new Product();
        prod2.SetName("Blazin' Glory");
        prod2.SetId("B1");
        prod2.SetPrice(24);
        prod2.SetQuantity(3);

        Product prod3 = new Product();
        prod3.SetName("Wings of Angels");
        prod3.SetId("B2");
        prod3.SetPrice(95);
        prod3.SetQuantity(5);

        Product prod4 = new Product();
        prod4.SetName("CatsNDogs");
        prod4.SetId("C1");
        prod4.SetPrice(15);
        prod4.SetQuantity(15);

        Product prod5 = new Product();
        prod5.SetName("Applebee");
        prod5.SetId("C1");
        prod5.SetPrice(2);
        prod5.SetQuantity(77);

        Address add1 = new Address();
        add1.SetAddress("23 Wallaby Way");
        add1.SetCity("Sydney");
        add1.SetState("Easter Australia");
        add1.SetCountry("Australia");

        Address add2 = new Address();
        add2.SetAddress("123 4th Street");
        add2.SetCity("Baltimore");
        add2.SetState("Maryland");
        add2.SetCountry("USA");

        Customer cust1 = new Customer();
        cust1.SetName("Walleyed Mates");
        cust1.SetAddress(add1);

        Customer cust2 = new Customer();
        cust2.SetName("Michael Elwell Construction");
        cust2.SetAddress(add2);

        Order ord1 = new Order();
        ord1.SetCustomer(cust1);
        ord1.AddProduct(prod1);
        ord1.AddProduct(prod5);

        Order ord2 = new Order();
        ord2.SetCustomer(cust2);
        ord2.AddProduct(prod2);
        ord2.AddProduct(prod3);
        ord2.AddProduct(prod4);

        ord1.MakePackingLabel();
        ord1.MakeShippingLabel();
        Console.WriteLine($"{ord1.TotalOrderCost}");

        ord2.MakePackingLabel();
        ord2.MakeShippingLabel();
        Console.WriteLine($"{ord2.TotalOrderCost}");
    }
}