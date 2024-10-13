using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Video> _videos = new List<Video>();
        Video v1 = new Video();
        Comment c1 = new Comment();
        Comment c3 = new Comment();
        Comment c5 = new Comment();

        Video v2 = new Video();
        Comment c2 = new Comment();
        Comment c4 = new Comment();
        Comment c6 = new Comment();

        Video v3 = new Video();
        Comment c7 = new Comment();
        Comment c8 = new Comment();
        Comment c9 = new Comment();

        v1._title = "How to brush your teeth";
        v1._author = "John Doe";
        v1._length = 123;
        _videos.Add(v1);
        c1._commentName = "Cage";
        c1._commentText = "Amazing!";
        c3._commentName = "Jeff";
        c3._commentText = "I love your videos!";
        c5._commentName = "Joe";
        c5._commentText = "Best YouTuber ever!";
        v1.MakeComment(c1);
        v1.MakeComment(c3);
        v1.MakeComment(c5);
        
        v2._title = "How to feed a dog";
        v2._author = "Mary Jane";
        v2._length = 150;
        _videos.Add(v2);
        c2._commentName = "Jimmy";
        c2._commentText = "So insightful!";
        c4._commentName = "Linda";
        c4._commentText = "I love dogs!";
        c6._commentName = "Mark";
        c6._commentText = "Woof, Woof";
        v2.MakeComment(c2);
        v2.MakeComment(c4);
        v2.MakeComment(c6);

        v3._title = "How to drive a car";
        v3._author = "Harry Potter";
        v3._length = 193;
        _videos.Add(v3);
        c7._commentName = "Chad";
        c7._commentText = "That is my favorite car!";
        c8._commentName = "Lisa";
        c8._commentText = "I have a Porsche";
        c9._commentName = "Brek";
        c9._commentText = "Best tutorial ever!";
        v3.MakeComment(c7);
        v3.MakeComment(c8);
        v3.MakeComment(c9);
  
        void DisplayAll()
        {
            foreach (var video in _videos)
            {
                Console.WriteLine("");
                video.Display();
            }
        }
        DisplayAll();
    }
}
