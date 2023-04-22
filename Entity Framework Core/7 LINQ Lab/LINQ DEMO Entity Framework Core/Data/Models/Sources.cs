using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LINQ_DEMO_Entity_Framework_Core.Data.Models
{
    public partial class Sources
    {
        public Sources()
        {
            ArtistMetadata = new HashSet<ArtistMetadata>();
            SongMetadata = new HashSet<SongMetadata>();
            Songs = new HashSet<Songs>();
        }

        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Name { get; set; }

        [InverseProperty("Source")]
        public virtual ICollection<ArtistMetadata> ArtistMetadata { get; set; }
        [InverseProperty("Source")]
        public virtual ICollection<SongMetadata> SongMetadata { get; set; }
        [InverseProperty("Source")]
        public virtual ICollection<Songs> Songs { get; set; }
    }
}
