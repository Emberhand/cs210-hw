public class Activity {
    protected string _date;
    protected int _length;

    public virtual int CalculateDistance() {

    }
    public virtual int CalculateSpeed() {

    }
    public virtual int CalculatePace() {

    }
    public string GetSummary(name) {
        string summary = $"{_date} {name} ({_length}) - Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} min per mile";
        return summary;
    }
}