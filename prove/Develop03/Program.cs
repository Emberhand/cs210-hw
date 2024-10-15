using System;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Word.Show();
        Console.WriteLine($"{Scripture.GetDisplayText()}");
        string ans = Console.ReadLine();

        
        while (!(ans == "quit")) {
            Console.Clear();
            Word.Hide();
            Console.WriteLine($"{Scripture.GetDisplayText()}");
            ans = Console.ReadLine();
        }

        Word.Hide();
    }
}

class Scripture {
    // private Reference _reference;
    // private List<Word> _words;

    // private Scripture(Reference Reference, string text);

    public static void HideRandomWords(int numberToHide) {

    }
    public static string GetDisplayText() {
        return $"{Reference.GetDisplayText()} - {Word.GetDisplayText()}";
    }
    // public static bool IsCompletelyHidden() {
        
    // }

}

class Reference {
    private static string _book;
    private static int _chapter;
    private static int _verse;
    // private static int _endVerse;

    // private Reference(string book, int chapter, int verse);
    // private Reference(string book, int chapter, int startVerse, int endVerse);

    public static string GetDisplayText() {
        _book = "Jeremiah";
        _chapter = 23;
        _verse = 28;
        return $"{_book} {_chapter}: {_verse}";
    }

}

class Word {
    private static string _text;
    private bool _isHidden;

    private Word(string text) {
        text = "";
    }
        

    public static void Hide() {
        foreach (string val in _text.Split(" "))
            Word 
            Console.WriteLine(val);
        
    }
    public static void Show() {
        _text = "The prophet that hath a dream, let him tell a dream; and he that hath my word, let him speak my word faithfully. What is the chaff to the wheat? saith the Lord.";
    }
    // public static bool IsHidden() {
        // return true;
    // }
    public static string GetDisplayText() {
        return _text;
    }
}