using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingService
{
    [Table("hotel")]
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("hotelName")]
        public string HotelName { get; set; }

        [Column("roomType")]
        public string RoomType { get; set; }

        [Column("guestNum")]
        public int GuestNum { get; set; }

        [Column("booked")]
        public bool Booked { get; set; }

        [Column("createdAt")]
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
    }
}
