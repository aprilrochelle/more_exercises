using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string song, string artist)> goodSongs = new List<(string song, string artist)>();

            HashSet<(string song, string artist)> allSongs = new HashSet<(string song, string artist)>() {
              ("PYT", "Michael Jackson"),
              ("Jealous", "Beyoncé"),
              ("Respect", "Aretha Franklin"),
              ("Just Like", "Marvin Gaye"),
              ("This Afternoon", "Nickelback"),
              ("Lullaby", "Nickelback"),
              ("Too Bad", "Nickelback")
            };

            foreach ((string song, string artist) s in allSongs)
            {
                if (s.artist != "Nickelback") {
                  goodSongs.Add(s);
                }
            }

            Console.WriteLine("Good Songs: ");
            foreach ((string song, string artist) s in goodSongs)
            {
                Console.WriteLine($"\"{s.song}\" by {s.artist}");
            }
        }
    }
}
