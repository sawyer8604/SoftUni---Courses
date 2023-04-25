using System;
using System.Collections.Generic;
using System.Text;

namespace C__Auto_Mapping_Objects_Demo
{
    public class SongInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Artist { get; set; }

        public DateTime CreatedOn { get; set; }
        public string SearchTerms { get; set; }
        public string SourceName { get; set; }


    }
}
