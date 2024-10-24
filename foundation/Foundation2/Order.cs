public class Order {
    private static List<Product> _products;
    private Customer _customer;

    public int TotalOrderCost() {
        int orderTotal = 0;
        foreach (Product p in _products) {
            orderTotal = orderTotal + p.GetTotalCost();
        }
        if (_customer.CheckUSA() == true) {
            orderTotal = orderTotal + 5;
        }
        else {
            orderTotal = orderTotal + 35;
        }
        return orderTotal;
    }
    public void MakePackingLabel() {
        foreach (Product p in _products) {
            Console.WriteLine($"{p.GetName} - {p.GetId}");
        }
    }
    public void MakeShippingLabel() {
        Console.WriteLine($"{_customer.GetName}");
        Console.WriteLine($"{_customer.GetAddress}");
    }
    public void SetCustomer(Customer customer) {
        _customer = customer;
    }
    public void AddProduct(Product product) {
        _products.Add(product);
    }
}