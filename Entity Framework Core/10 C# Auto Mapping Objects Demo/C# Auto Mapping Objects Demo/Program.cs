namespace C__Auto_Mapping_Objects_Demo
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data.Models;
    using MapperProfiles;
    using Data;
    using Newtonsoft.Json;
    using System;   
    using System.Linq;
    

    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine(JsonConvert.SerializeObject(songs, Formatting.Indented));

            var config = new MapperConfiguration(config =>
            {
                config.AddProfile(new SongInfoDtoProfile());
            });

            var mapper = config.CreateMapper();

            var db = new MusicXContext();

            Songs song = db.Songs.Where(x => x.Id == 4)
                .FirstOrDefault();

            var songInfo = mapper.Map<SongInfo>(song);


            Console.WriteLine(JsonConvert.SerializeObject(songInfo, Formatting.Indented));

            var songs = db.Songs
                .ProjectTo<SongInfo>(config)
                .ToArray();

            Console.WriteLine(JsonConvert.SerializeObject(songs, Formatting.Indented));

        }
        
    }
}
