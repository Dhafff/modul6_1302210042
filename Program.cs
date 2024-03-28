namespace modul6_1302210042;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            // saya tube video
            SayaTubeVideo akuTube1 = new SayaTubeVideo("Review Film Batman (2021)");
            akuTube1.IncreasePlayCount(5);

            SayaTubeVideo akuTube2 = new SayaTubeVideo("Review Film Oppenheimer");
            akuTube2.IncreasePlayCount(15);

            SayaTubeVideo akuTube3 = new SayaTubeVideo("Review Film Barbie (2023)");
            akuTube3.IncreasePlayCount(5);

            SayaTubeVideo akuTube4 = new SayaTubeVideo("Review Film Avengers: Endgame");
            akuTube4.IncreasePlayCount(15);

            SayaTubeVideo akuTube5 = new SayaTubeVideo("Review Film Manchaster-by-the-Sea");
            akuTube5.IncreasePlayCount(5);

            SayaTubeVideo akuTube6 = new SayaTubeVideo("Review Film Kimi no Nawa");
            akuTube6.IncreasePlayCount(15);

            SayaTubeVideo akuTube7 = new SayaTubeVideo("Review Film Weathering with You");
            akuTube7.IncreasePlayCount(5);

            SayaTubeVideo akuTube8 = new SayaTubeVideo("Review Film Godzilla: King of the Monster");
            akuTube8.IncreasePlayCount(15);

            SayaTubeVideo akuTube9 = new SayaTubeVideo("Review Film Agak Laen");
            akuTube9.IncreasePlayCount(5);

            SayaTubeVideo akuTube10 = new SayaTubeVideo("Review Film Spider-Man: Across the Spider-Verse");
            akuTube10.IncreasePlayCount(15);

            // saya tube user
            SayaTubeUser userTube = new SayaTubeUser("Dhafgoes");

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
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}