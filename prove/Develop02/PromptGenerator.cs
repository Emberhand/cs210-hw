public class PromptGenerator {
    public static List<string> _prompts = new List<string> {
        "How have I seen the hand of the Lord today?",
        "Did I meet anyone new today? Why or why not?",
        "What was the biggest triumph and the biggest failure of the day?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?"
    };

    public static string GetRandomPrompt() {
        Random rnd = new Random();
        int number = rnd.Next(0, 6);
        string prompt = _prompts[number];
        return prompt;
    }
}