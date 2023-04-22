using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LINQ_DEMO_Entity_Framework_Core.Data.Models
{
    public partial class Artists
    {
        public Artists()
        {
            ArtistMetadata = new HashSet<ArtistMetadata>();
            SongArtists = new HashSet<SongArtists>();
        }

        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string Name { get; set; }

        [InverseProperty("Artist")]
        public virtual ICollection<ArtistMetadata> ArtistMetadata { get; set; }
        [InverseProperty("Artist")]
        public virtual ICollection<SongArtists> SongArtists { get; set; }
    }
}
