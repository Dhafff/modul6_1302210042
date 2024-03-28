using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210042;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string username)
    {
        this.id = GenerateRandomId();
        this.uploadedVideos = new List<SayaTubeVideo>();
        this.Username = username;
    }

    private int GenerateRandomId()
    {
        Random rnd = new Random();
        return rnd.Next(10000, 99999);
    }

    public int GetTotalVideoPlayCount()
    {
        return uploadedVideos.Count;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        this.uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine($"Video {i+1} judul: " + this.uploadedVideos[i].title);
        }
    }
}
