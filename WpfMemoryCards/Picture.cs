using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfMemoryCards
{
    // public property is important to this class!
    [Table("Pictures")]
    public class Picture
    {
        // Picture key
        [Column("id"), Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; } // It is important to have public property

        // Picture itself
        [Column("value"), Required, MaxLength(255)]
        public string Value { get; set; }

        // Everything is default
        Picture()
        {
            this.Id = default;
            this.Value = default;
        }
    }
}
