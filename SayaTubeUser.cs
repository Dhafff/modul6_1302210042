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
        if (username == null || username.Length >= 100 )
        {
            throw new ArgumentException("Username melebihi 100 kata atau belum diisi");
        }
        this.id = GenerateRandomId();
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
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
        if (video.title == null)
        {
            throw new ArgumentException("Judul video belum diisi atau jumlah penambahan pemutaran melebihi batas");
        } 
        {
            this.uploadedVideos.Add(video);
        }
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            if(i > 7)
            {
                Console.WriteLine("Video tidak dapat ditambahkan karena sudah mencapai batas maks yaitu 8 video");
            } else
            {
                Console.WriteLine($"Video {i + 1} judul: " + this.uploadedVideos[i].title);
            }            
        }
    }
}
