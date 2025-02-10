using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("Product Review: BDMX", "Dubem Eze", 315);
        video1.AddComment("Raymond", "Great video, very informative!");
        video1.AddComment("Dew@789", "I love this demo.");
        video1.AddComment("Charlys-angelz", "Very informative.");
        video1.AddComment("Lessi", "Thanks for sharing.");
        video1.AddComment("Danny", "Very informative, How can I get one.");
        video1.AddComment("Chenny-angelz", "Amazing! Thanks for the video.");
        video1.AddComment("Victor", "Very informative, thanks for sharing.");

        Video video2 = new Video("Product Review - JBL251", "Billy Amstrong", 380);
        video2.AddComment("Rose", "Great video, very informative!");
        video2.AddComment("Luke", "Wonderful! thanks for the review it's very informative, love the product demo.");
        video2.AddComment("Lyold", "Thanks for the review!");
        video2.AddComment("Jazy@dawn", "Amazing!");

        Video video3 = new Video("Unboxing The new BDMX", "Jane Chinwo", 189);
        video3.AddComment("Kaycee", "This product is great,exactly what I need. How can I get one?");
        video3.AddComment("Diva", "The packaging is top notch, looks beautifully amazing!");
        video3.AddComment("Shawn", "See packaging, I want to buy this product now.");
        video3.AddComment("chyoma", "See the packaging, omo this product beautiful inside - out. A must have product, how can I get one.");

        Video video4 = new Video("How to Use the new BDMX", "Zuby Micheals", 520);
        video4.AddComment("Aijay", "The tutorial was really helpful. Thanks.");
        video4.AddComment("Jennybliz", "I had trouble with step 3, but this video cleared it up.");
        video4.AddComment("Iris Blue", "More tutorials like this, please! This is awesome");
        video4.AddComment("God'sFavour", "Great! This video answers it all. Exactly what I need right now.");
        
        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Iterate through each video and display its details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
