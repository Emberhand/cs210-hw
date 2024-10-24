using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video();
        vid1._title = "The Oddessey";
        vid1._author = "Mr. History";
        vid1._length = 1678;
        Comment comment1 = new Comment();
        comment1._user = "fantasticmrfox";
        comment1._text = "Oh yeah!! I love this story! Still think it would have been cooler if Odyseus killed Scylla tho";
        Comment comment2 = new Comment();
        comment2._user = "destroyer334";
        comment2._text = "lame";
        Comment comment3 = new Comment();
        comment3._user = "sleepyhead";
        comment3._text = "I like the songs you used. 10/10";

        Video vid2 = new Video();
        vid2._title = "The Illiad";
        vid2._author = "Mr. History";
        vid2._length = 1579;
        Comment comment4 = new Comment();
        comment4._user = "odyseusisbae<3";
        comment4._text = "<3 <3 <3";
        Comment comment5 = new Comment();
        comment5._user = "destroyer334";
        comment5._text = "first video was better";
        Comment comment6 = new Comment();
        comment6._user = "mastercheif117";
        comment6._text = "Odie is the first chad for real";
        Comment comment7 = new Comment();
        comment7._user = "mr_smart";
        comment7._text = "Come check out my channel! Please subscribe :'(";

        Video vid3 = new Video();
        vid3._title = "God of War";
        vid3._author = "gamergirl2";
        vid3._length = 20095;
        Comment comment8 = new Comment();
        comment8._user = "capking3";
        comment8._text = "ey yo u kinda cute tho";
        Comment comment9 = new Comment();
        comment9._user = "phil_lubuster";
        comment9._text = "Thanks for making this. I don't have time to play when I'm working, but it's so good to watch!";
        Comment comment10 = new Comment();
        comment10._user = "destroyer334";
        comment10._text = "imagine taking 20095 seconds to beat the game";

        vid1._comments.Add(comment1);
        vid1._comments.Add(comment2);
        vid1._comments.Add(comment3);
        vid2._comments.Add(comment4);
        vid2._comments.Add(comment5);
        vid2._comments.Add(comment6);
        vid2._comments.Add(comment7);
        vid3._comments.Add(comment8);
        vid3._comments.Add(comment9);
        vid3._comments.Add(comment10);


        vid1.displayVideo();
        vid2.displayVideo();
        vid3.displayVideo();
    }
}