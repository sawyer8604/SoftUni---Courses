using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LINQ_DEMO_Entity_Framework_Core.Data.Models
{
    public partial class ArtistMetadata
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int ArtistId { get; set; }
        public int Type { get; set; }
        public string Value { get; set; }
        public int? SourceId { get; set; }
        public string SourceItemId { get; set; }

        [ForeignKey(nameof(ArtistId))]
        [InverseProperty(nameof(Artists.ArtistMetadata))]
        public virtual Artists Artist { get; set; }
        [ForeignKey(nameof(SourceId))]
        [InverseProperty(nameof(Sources.ArtistMetadata))]
        public virtual Sources Source { get; set; }
    }
}
