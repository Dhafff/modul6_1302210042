namespace modul6_1302210042;

internal class Program
{
    private static void Main(string[] args)
    {
        // saya tube video
        SayaTubeVideo akuTube1 = new SayaTubeVideo("Review Film Batman (2021)");
        SayaTubeVideo akuTube2 = new SayaTubeVideo("Review Film Oppenheimer");
        SayaTubeVideo akuTube3 = new SayaTubeVideo("Review Film Barbie (2023)");
        SayaTubeVideo akuTube4 = new SayaTubeVideo("Review Film Avengers: Endgame");
        SayaTubeVideo akuTube5 = new SayaTubeVideo("Review Film Manchaster-by-the-Sea");
        SayaTubeVideo akuTube6 = new SayaTubeVideo("Review Film Kimi no Nawa");
        SayaTubeVideo akuTube7 = new SayaTubeVideo("Review Film Weathering with You");
        SayaTubeVideo akuTube8 = new SayaTubeVideo("Review Film Godzilla: King of the Monster");
        SayaTubeVideo akuTube9 = new SayaTubeVideo("Review Film Agak Laen");
        SayaTubeVideo akuTube10 = new SayaTubeVideo("Review Film Spider-Man: Across the Spider-Verse");

        // saya tube user
        SayaTubeUser userTube = new SayaTubeUser("Dhafa Arrizki Gusman");

        userTube.AddVideo(akuTube1);
        userTube.AddVideo(akuTube2);
        userTube.AddVideo(akuTube3);
        userTube.AddVideo(akuTube4);
        userTube.AddVideo(akuTube5);
        userTube.AddVideo(akuTube6);
        userTube.AddVideo(akuTube7);
        userTube.AddVideo(akuTube8);
        userTube.AddVideo(akuTube9);
        userTube.AddVideo(akuTube10);

        userTube.PrintAllVideoPlaycount();
    }
}