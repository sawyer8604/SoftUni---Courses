using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            int numberOfSong = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < numberOfSong; i++)
            {
                string[] commands = Console.ReadLine().Split('_');

                string type = commands[0];
                string name = commands[1];
                string time = commands[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);

            }

            string typeList = Console.ReadLine();

            if(typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }

            }
            else
            {
                List<Song> filteredTypeList = songs.Where(song => song.TypeList == typeList).ToList();

                foreach (Song song in filteredTypeList)
                {
                    Console.WriteLine(song.Name);

                }

            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }


    }
}
