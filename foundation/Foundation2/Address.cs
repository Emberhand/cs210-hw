public class Address {
    private static string _streetAddress;
    private static string _city;
    private static string _state;
    private static string _country;

    public bool CheckUSA() {
        if (_country == "USA") {
            return true;
        }
        else {
            return false;
        }
    }

    public string DisplayAddress() {
        string address = $"{_streetAddress} {_city}, {_state}, {_country}";
        return address;
    }
    public void SetCountry(string country) {
        _country = country;
    }
    public void SetAddress(string address) {
        _streetAddress = address;
    }
    public void SetState(string state) {
        _state = state;
    }
    public void SetCity(string city) {
        _city = city;
    }
}