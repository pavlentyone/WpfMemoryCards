using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WpfMemoryCards
{
    // public property is important to this class
    [Table("Tags")]
    public class Tag
    {
        // Tag key
        [Column("id"), Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; } // It is important to have public property

        // Tag name
        [Column("value"), Required, MaxLength(255)]
        public string Value { get; set; }

        // Everything is default
        public Tag()
        {
            this.Id = default;
            this.Value = default;
        }
    }
}
