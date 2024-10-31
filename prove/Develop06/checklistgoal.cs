public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points) {

    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}