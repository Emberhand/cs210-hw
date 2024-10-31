public class BreathingActivity : Activity {
    public BreathingActivity() {

    }

    public void Run() {
        SetName("Breathing");
        SetDescription("This activity focuses on relaxation. It will walk you through breathing in and then out slowly. Clear your mind and focus on your breathing.");
        DisplayStartingMessage();
        SetDuration(Console.ReadLine());
        int length = int.Parse(GetDuration());
        Console.Clear();

        Console.WriteLine("Get ready!");
        ShowSpinner(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(length);
        while (startTime < futureTime) {
            Console.WriteLine("Breathe in . . .");
            ShowCountDown(4);
            Console.WriteLine("Hold . . .");
            ShowCountDown(7);
            Console.WriteLine("Breathe out . . .");
            ShowCountDown(8);
            Console.WriteLine("");
            startTime = DateTime.Now;
        }

        DisplayEndingMessage();
        ShowSpinner(5);
        Console.Clear();
    }
}