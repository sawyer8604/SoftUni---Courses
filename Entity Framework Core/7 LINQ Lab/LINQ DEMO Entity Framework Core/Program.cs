using LINQ_DEMO_Entity_Framework_Core.Data;
using System;
using System.Linq;
using System.Text;


namespace LINQ_DEMO_Entity_Framework_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            var db = new MusicXContext();

            var songs = db.Songs
                 .Where(x => x.Source.Name == "User")
                 .ToArray();

            foreach (var song in songs)
            {
                Console.WriteLine(song.Name);
            }

            var artists = db.Artists
                .OrderByDescending(x => x.SongArtists.Count())
                .Where(x => x.SongArtists.Count(s => s.Song.Name.Contains("a")) > 50)
                .Select(x => new
                {
                    x.Name,
                    Count = x.SongArtists.Count(),
                    CountA = x.SongArtists.Count(s => s.Song.Name.Contains("a"))
                })
                .ToArray();

            foreach (var artist in artists)
            {
                Console.WriteLine(artist);
            }


            var artists1 = db.Artists
                .Select(x => x.SongArtists.Select(sa => sa.Song.Name))
                .ToList();

            foreach (var song in artists1)
            {
                foreach (var s in song)
                {
                    Console.WriteLine(s);
                }
            }


        }
    }
}
