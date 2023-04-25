using AutoMapper;
using C__Auto_Mapping_Objects_Demo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C__Auto_Mapping_Objects_Demo.MapperProfiles
{
    public class SongInfoDtoProfile: Profile
    {

        public SongInfoDtoProfile()
        {
            this.CreateMap<Songs, SongInfo>();
        }
    }
}
