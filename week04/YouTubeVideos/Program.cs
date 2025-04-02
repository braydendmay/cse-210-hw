using System;

class Program
{
    static void Main(string[] args)
    {
            // List to store videos 
            List<Video> videos = new List<Video>();

            // Creating sample videos (Instantiation)
            Video video1 = new Video("Starter House", "BdoubleO100", 789);
            Video video2 = new Video("Terraforming Garden Area", "GoodTimeWithScar", 856);
            Video video3 = new Video("Color Theory For Beginners", "Snarple", 300);

            // Adding comments to the first video (Instantiation)
            video1.AddComment(new Comments("JayMan35", "Lovely and quaint starter house!"));
            video1.AddComment(new Comments("Leah_Jahn24", "Love the transition between the cliff and moss!"));
            video1.AddComment(new Comments("Noob12_", "Any Chance you could teach me?"));

            // Adding comments to the second video (Instantiation)
            video2.AddComment(new Comments("Wild_Dusk", "Loving the look of those rose bushes!"));
            video2.AddComment(new Comments("Annoying-duck", "Litteraly So jealous!"));
            video2.AddComment(new Comments("BeefJerky7843", "My New Favorite channel"));

            // Adding comments to the third video (Instantiation)
            video3.AddComment(new Comments("FANatict", "So Helpful!!!!"));
            video3.AddComment(new Comments("Mumbo Jumbo", "Could do with a little more in depth explanation."));
            video3.AddComment(new Comments("JimNotHome", "Nice!"));

            // Adding videos to the list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // Displaying video details
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                foreach (Comments comment in video.Comments)
                {
                    Console.WriteLine($"{comment.Name}: {comment.TextComment}");
                }
                Console.WriteLine();
            }
            
    }
}