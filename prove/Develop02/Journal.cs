public class Journal {
    public static List<Entry> _entries = new List<Entry>();

    public static void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }
    public static void DisplayAll() {
        foreach (Entry i in _entries) {
            Console.WriteLine($"{i._date} - Prompt: {i._promptText}");
            Console.WriteLine($"{i._entryText}");
            Console.WriteLine("");
        }

    }
    public static void SaveToFile(string file) {
        
        foreach (Entry i in _entries) {
            using (StreamWriter text = File.AppendText(file)) {
            text.WriteLine($"{i._date} - Prompt: {i._promptText}");
            text.WriteLine($"{i._entryText}");
            text.WriteLine("");
            }
        }
    }
    public static void LoadFromFile(string file) {
        string text = File.ReadAllText(file);
        Console.WriteLine(text);
    }
}