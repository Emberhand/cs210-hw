public class ReflectionActivity : Activity {
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() {
        
    }

    public void Run() {
        PopulatePrompts();
        PopulateQuestions();
        SetName("Reflection");
        SetDescription("This activity is designed to help you reflect on some of your memories. Consider the prompt and then the specific questions that follow.");
        DisplayStartingMessage();
        SetDuration(Console.ReadLine());
        int length = int.Parse(GetDuration());
        Console.Clear();

        Console.WriteLine("Get ready!");
        ShowSpinner(5);
        Console.WriteLine("");

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(length);
        Thread.Sleep(3000);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime) {
            DisplayQuestions();
            ShowSpinner(10);
        }
        Console.WriteLine("");

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
    public string GetRandomQuestion() {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }
    public void DisplayPrompt() {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestions() {
        Console.WriteLine($"> {GetRandomQuestion()}");
    }

    public void PopulatePrompts() {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }
    public void PopulateQuestions() {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
}