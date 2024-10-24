public class Video {
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void displayVideo() {
        Console.WriteLine($"\"{_title}\"");
        Console.WriteLine($"by {_author}");
        Console.WriteLine($"{_length} seconds");
        Console.WriteLine("");
        Console.WriteLine("Comments:");
        foreach (Comment i in _comments) {
            i.displayComment();
        }
    }
}