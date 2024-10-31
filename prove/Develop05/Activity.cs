public class Activity {
    private string _name;
    private string _description;
    private string _duration;

    public Activity() {

    }

    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to the {GetName()} Activity!");
        Console.WriteLine("");
        Console.WriteLine(GetDescription());
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like this session to be?");
    }
    public void DisplayEndingMessage() {
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()} Activity!");
    }
    public void ShowSpinner(int seconds) {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int i = 0;
        List<string> animations = new List<string>();
        animations.Add("O");
        animations.Add("o");
        animations.Add(".");
        animations.Add("o");

        while (startTime < futureTime) {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count) {
                i = 0;
            }

            startTime = DateTime.Now;
        }
    }
    public void ShowCountDown(int seconds) {
        int secondsLeft = seconds;
        while (secondsLeft > 0) {
            Console.Write($"{secondsLeft}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            secondsLeft = secondsLeft - 1;
        }
    }
    public void SetName(string name) {
        _name = name;
    }
    public string GetName() {
        return _name;
    }
    public void SetDescription(string description) {
        _description = description;
    }
    public string GetDescription() {
        return _description;
    }
    public void SetDuration(string duration) {
        _duration = duration;
    }
    public string GetDuration() {
        return _duration;
    }
}