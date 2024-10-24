public class Product
{
    private static string _name;
    private static string _productId;
    private static int _price;
    private static int _quantity;

    public Product() {
        _productId = "";
    }

    public int GetTotalCost()
    {
        int cost = _price * _quantity;
        return cost;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _productId;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetId(string id)
    {
        _productId = id;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}