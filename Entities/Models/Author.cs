using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Author
    {
        public long Id { get; set; }

        [Required]
        [StringLength(800)]
        public string FullName { get; set; } = "";

        [Column(TypeName = "nvarchar(1000)")]
        public string? Biography { get; set; }

        [Range(-4000, 2100)]
        public short BirthYear { get; set; }

        [Range(-4000, 2100)]
        public short? DeathYear { get; set; }

        [JsonIgnore]
        public List<AuthorBook>? AuthorBooks { get; set; }
    }
}
