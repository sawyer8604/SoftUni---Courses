using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LINQ_DEMO_Entity_Framework_Core.Data.Models
{
    public partial class Songs
    {
        public Songs()
        {
            SongArtists = new HashSet<SongArtists>();
            SongMetadata = new HashSet<SongMetadata>();
        }

        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        [Required]
        public string Name { get; set; }
        public int? SourceId { get; set; }
        public string SourceItemId { get; set; }
        public string SearchTerms { get; set; }

        [ForeignKey(nameof(SourceId))]
        [InverseProperty(nameof(Sources.Songs))]
        public virtual Sources Source { get; set; }
        [InverseProperty("Song")]
        public virtual ICollection<SongArtists> SongArtists { get; set; }
        [InverseProperty("Song")]
        public virtual ICollection<SongMetadata> SongMetadata { get; set; }
    }
}
