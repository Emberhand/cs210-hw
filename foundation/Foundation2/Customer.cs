public class Customer {
    private string _name;
    private static Address _address;

    public bool CheckUSA() {
        return _address.CheckUSA();
    }
    public string GetName() {
        return _name;
    }
    public string GetAddress() {
        return _address.DisplayAddress();
    }
    public void SetName(string name) {
        _name = name;
    }
    public void SetAddress(Address address) {
        _address = address;
    }
}