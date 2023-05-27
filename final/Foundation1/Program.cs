using System;

class Program
{
    static void Main(string[] args)
    {
        Video newVideo1 = new Video("Sassy 6-Year-Old", "Naya Hess", 89);
        Video newVideo2 = new Video("Adorable Little Girl", "Esper Hess", 120);
        Video newVideo3 = new Video("Toddler Nightmare", "Jace Hess", 67);
        Comment com1a = new Comment("Naya Hess", "You deal with him. I can't even handle it right now.");
        Comment com1b = new Comment("Naya Hess", "I know, Mom!");
        Comment com1c = new Comment("Naya Hess", "Why do you always get the easy jobs, Mom?");
        Comment com2a = new Comment("Esper Hess", "Who are the bad guys? Is that the bad guy? Who's the bad guy again?");
        Comment com2b = new Comment("Esper Hess", "Mommy, mommmy, mommy!");
        Comment com2c = new Comment("Esper Hess", "I just love you, Mom.");
        Comment com3a = new Comment("Jace Hess", "MaMa!");
        Comment com3b = new Comment("Jace Hess", "DaDa!");
        Comment com3c = new Comment("Jace Hess", "Hawwwt!");
        newVideo1.AddComment(com1a);
        newVideo1.AddComment(com1b);
        newVideo1.AddComment(com1c);
        newVideo2.AddComment(com2a);
        newVideo2.AddComment(com2b);
        newVideo2.AddComment(com2c);
        newVideo3.AddComment(com3a);
        newVideo3.AddComment(com3b);
        newVideo3.AddComment(com3c);
        newVideo1.DisplayVideo();
        newVideo2.DisplayVideo();
        newVideo3.DisplayVideo();


        

    }
}