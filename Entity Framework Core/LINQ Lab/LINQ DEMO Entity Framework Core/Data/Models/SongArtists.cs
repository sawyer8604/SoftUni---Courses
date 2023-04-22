using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LINQ_DEMO_Entity_Framework_Core.Data.Models
{
    public partial class SongArtists
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int SongId { get; set; }
        public int ArtistId { get; set; }
        public int Order { get; set; }

        [ForeignKey(nameof(ArtistId))]
        [InverseProperty(nameof(Artists.SongArtists))]
        public virtual Artists Artist { get; set; }
        [ForeignKey(nameof(SongId))]
        [InverseProperty(nameof(Songs.SongArtists))]
        public virtual Songs Song { get; set; }
    }
}
