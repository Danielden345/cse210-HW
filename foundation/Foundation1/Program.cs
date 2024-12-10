using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create 3-4 video objects and add them to the list
        Video video1 = new Video("Jeremy Zuckerman", "Into a Nighttime Sky", 126);
        video1.AddComment(new Comment("Kakajan", "Finally, one of my favourite soundtrack has released, thank you a lot, Jeremy Zuckerman!"));
        video1.AddComment(new Comment("boyinblue", "A song that, in my opinion, captures the very core of the show. It gives room for melancholy, playfulness, wonder, nostalgia, beauty."));
        video1.AddComment(new Comment("Blunderman", "There are parts of this song in the Avatar's Love theme."));

        Video video2 = new Video("Polyphia", "Ego Death feat. Steve Vai (official Video)", 351);
        video2.AddComment(new Comment("teknofreak", "I'm at a loss for words."));
        video2.AddComment(new Comment("Diana", "The way Vai makes the guitar sing... absolutely gorgeous."));
        video2.AddComment(new Comment("Ryan", "I'm always happy when Vai collaborates with the newest generation of musicians."));

        Video video3 = new Video("Aniplex", "TO BE HERO X", 368);
        video3.AddComment(new Comment("Dave", "The blend of 2D and 3D is immaculate, and even though I don’t fully understand the superpower it’s still super cool!"));
        video3.AddComment(new Comment("Rayfield", "When your imagination has no limits, then neither must your skills."));
        video3.AddComment(new Comment("koichi", "This is like arcane spider verse and cyberpunk edgerunners made a show."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list and display details
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine($"Number of Comments: {video.CountComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment}");
            }
            Console.WriteLine(new string('-', 40)); // Separator for clarity
        }
    }
}
