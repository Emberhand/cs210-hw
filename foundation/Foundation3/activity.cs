public abstract class Activity {
    protected string _date;
    protected int _length;

    public abstract int CalculateDistance();
    public abstract int CalculateSpeed();
    public abstract int CalculatePace();
    public string CreateLabel();
}