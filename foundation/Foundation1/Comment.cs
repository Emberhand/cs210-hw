public class Comment {
    public string _user;
    public string _text;
    
    public void displayComment() {
        Console.WriteLine($"{_user}");
        Console.WriteLine($"\"{_text}\"");
        Console.WriteLine("");
    }
}
