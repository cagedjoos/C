using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Video> _videos = new List<Video>();
        Video v1 = new Video();
        Comment c1 = new Comment();

        Video v2 = new Video();
        Comment c2 = new Comment();

        v1._title = "How to brush your teeth";
        v1._author = "John Doe";
        v1._length = 123;
        _videos.Add(v1);
        c1._commentName = "Cage";
        c1._commentText = "Hello";
        v1.MakeComment(c1);
        

        v2._title = "How to feed a dog";
        v2._author = "Mary";
        v2._length = 150;
        _videos.Add(v2);
        c2._commentName = "Jimmy";
        c2._commentText = "So insightful!";
        v2.MakeComment(c2);
  
        void DisplayAll()
        {
            foreach (var video in _videos)
            {
                video.Display();
            }
        }
        DisplayAll();
    }
}
