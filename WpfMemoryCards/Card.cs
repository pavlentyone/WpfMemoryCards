using System;
using System.Windows.Controls;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace WpfMemoryCards
{
    // public property is important to this class
    [Table("Cards")]
    public class Card : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Key
        [Column("id"), Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; } // It is important to have public property

        //// Tag key and tag object
        [Column("tag_id")]
        protected uint? TagId { get; set; }
        [ForeignKey("TagId")]
        public Tag Tag { get; set; }

        // Picture key and picture object for the first card side
        [Column("pic1_id")]
        protected uint? Picture1Id { get; set; }
        [ForeignKey("Picture1Id")]
        public Picture Picture1 { get; set; }

        // Picture key and picture object for the second card side
        [Column("pic2_id")]
        protected uint? Picture2Id { get; set; }
        [ForeignKey("Picture2Id")]
        public Picture Picture2 { get; set; }

        // Text on the first side of a card
        [Column("text1"), Required, MaxLength(255)]
        public string Text1 { get; set; }
        // Text on the second side of a card
        [Column("text2"), MaxLength(255)]
        public string Text2 { get; set; }

        // Hint/Help/Comment on the first card sides
        [Column("hint1"), MaxLength(255)]
        public string Hint1 { get; set; }
        // Hint/Help/Comment on the second card sides
        [Column("hint2"), MaxLength(255)]
        public string Hint2 { get; set; }

        // A marker. It means this card is remembered/absorbed/understood
        [Column("absorbed", TypeName = "DateTime")] // Important to appoint data type directly to DateTime type
        public DateTime? Absorbed { get; set; }

        // A marker. It means this card was deleted. After some time every card with this marker with true value will be deleted
        [Column("deleted", TypeName = "DateTime")] // Important to appoint data type directly to DateTime type
        public DateTime? Deleted { get; set; }

        // Everything is default
        public Card()
        {
            this.Id         = default;
            this.TagId      = default;
            this.Picture1 = default;
            this.Picture2 = default;
            this.Text1      = default;
            this.Text2      = default;
            this.Hint1      = default;
            this.Hint1      = default;
            this.Absorbed   = default;
            this.Deleted    = default;
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
