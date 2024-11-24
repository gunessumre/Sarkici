using System;
using System.Collections.Generic;
using System.Linq;

class Sarkici
{
    public string Ad { get; set; }
    public string MuzikTuru { get; set; }
    public int CikisYili { get; set; }
    public int AlbumSatis { get; set; } 
}

class Program
{
    static void Main()
    {
        
        List<Sarkici> sarkicilar = new List<Sarkici>
        {
            new Sarkici { Ad = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968, AlbumSatis = 20 },
            new Sarkici { Ad = "Sezen Aksu", MuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatis = 10 },
            new Sarkici { Ad = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatis = 3 },
            new Sarkici { Ad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatis = 5 },
            new Sarkici { Ad = "Sıla", MuzikTuru = "Pop", CikisYili = 2009, AlbumSatis = 3 },
            new Sarkici { Ad = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatis = 10 },
            new Sarkici { Ad = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatis = 40 },
            new Sarkici { Ad = "Hande Yener", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatis = 7 },
            new Sarkici { Ad = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbumSatis = 5 },
            new Sarkici { Ad = "Gülben Ergen", MuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatis = 10 },
            new Sarkici { Ad = "Neşet Ertaş", MuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatis = 2 }
        };

        
        List<Sarkici> sIleBaslayan = sarkicilar.Where(s => s.Ad.StartsWith("S")).ToList();
        Console.WriteLine("Adı 'S' ile Başlayan Şarkıcılar:");
        foreach (Sarkici s in sIleBaslayan)
        {
            Console.WriteLine(s.Ad);
        }

        
        List<Sarkici> onMilyonUstu = sarkicilar.Where(s => s.AlbumSatis > 10).ToList();
        Console.WriteLine("\nAlbüm Satışları 10 Milyon'un Üzerinde Olan Şarkıcılar:");
        foreach (Sarkici s in onMilyonUstu)
        {
            Console.WriteLine(s.Ad);
        }

        
        List<Sarkici> eskiPopSarkicilar = sarkicilar
            .Where(s => s.CikisYili < 2000 && s.MuzikTuru.Contains("Pop"))
            .OrderBy(s => s.CikisYili)
            .ThenBy(s => s.Ad)
            .ToList();

        Console.WriteLine("\n2000 Yılı Öncesi Çıkış Yapmış ve Pop Müzik Yapan Şarkıcılar:");
        foreach (Sarkici s in eskiPopSarkicilar)
        {
            Console.WriteLine($"{s.Ad} - {s.CikisYili}");
        }

        
        Sarkici enCokSatan = sarkicilar.OrderByDescending(s => s.AlbumSatis).First();
        Console.WriteLine($"\nEn Çok Albüm Satan Şarkıcı: {enCokSatan.Ad} - {enCokSatan.AlbumSatis} milyon");

       
        Sarkici enYeniSarkici = sarkicilar.OrderByDescending(s => s.CikisYili).First();
        Sarkici enEskiSarkici = sarkicilar.OrderBy(s => s.CikisYili).First();

        Console.WriteLine($"\nEn Yeni Çıkış Yapan Şarkıcı: {enYeniSarkici.Ad} - {enYeniSarkici.CikisYili}");
        Console.WriteLine($"En Eski Çıkış Yapan Şarkıcı: {enEskiSarkici.Ad} - {enEskiSarkici.CikisYili}");
    }
}