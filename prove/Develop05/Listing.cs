public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {

    }

    public void Run() {
        PopulatePrompts();
        SetName("Reflection");
        SetDescription("This activity is designed to help you reflect on some of your memories. Consider the prompt and then the specific questions that follow.");
        DisplayStartingMessage();
        SetDuration(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get ready!");
        ShowSpinner(5);
        Console.WriteLine("");

        Console.WriteLine("Write as many responses as you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        List<string> responses = GetListFromUser();
        SetCount(responses.Count());
        Console.WriteLine("");
        Console.WriteLine($"You listed {GetCount()} items!");

        DisplayEndingMessage();
        ShowSpinner(5);
        Console.Clear();
    }
    public string GetRandomPrompt() {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
    public List<string> GetListFromUser() {
        int length = int.Parse(GetDuration());
        List<string> responses = new List<string> ();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(length);
        Thread.Sleep(3000);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime) {
            responses.Add(Console.ReadLine());
        }
        return responses;
    }
    public int GetCount()
    {
        return _count;
    }
    public void SetCount(int count)
    {
        _count = count;
    }
    public void PopulatePrompts() {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
}