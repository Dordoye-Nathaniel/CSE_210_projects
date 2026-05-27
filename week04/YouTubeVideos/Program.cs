using System;

class Program
{
    static void Main(string[] args)
    {
        // list to hold all videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Socialism and its impact on modern economies", "Journalist Klenam", 3600);
        v1.AddComennt(new Comment("Nathaniel", "Jerusalem has now been a modern world"));
        v1.AddComennt(new Comment("Alice", "Very insightful analysis."));
        v1.AddComennt(new Comment("Bob", "I learned a lot from this."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Introduction to C#", "Professor Mensah", 1200);
        v2.AddComennt(new Comment("Charlie", "Clear explanation of basics."));
        v2.AddComennt(new Comment("David", "Loved the examples."));
        v2.AddComennt(new Comment("Evelyn", "Helped me understand classes."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("History of Renewable Energy", "Dr. Akua", 2400);
        v3.AddComennt(new Comment("Frank", "Great overview of solar power."));
        v3.AddComennt(new Comment("Grace", "Wind energy section was excellent."));
        v3.AddComennt(new Comment("Henry", "Would love more on hydro."));
        videos.Add(v3);
        // Video 4
        Video v4 = new Video("Cooking with Cassava", "Chef Kwame", 1800);
        v4.AddComennt(new Comment("Isaac", "Cassava fish recipe was amazing!"));
        v4.AddComennt(new Comment("Janet", "Loved the step-by-step guide."));
        v4.AddComennt(new Comment("Kojo", "Please do more Ghanaian dishes."));
        videos.Add(v4);

        foreach (var video in videos)
        {
            System.Console.WriteLine($"Title: {video.Title}");
            System.Console.WriteLine($"Author: {video.Author}");
            System.Console.WriteLine($"Lenght(seconds): {video.Lenght}");
            System.Console.WriteLine($"Total comment: {video.NumberOfComments()}");

            video.DisplayComment();
            System.Console.WriteLine();

        }



        
    }
}