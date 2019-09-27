using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingService
{
    [Table("flight")]
    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("airlines")]
        public string Airlines { get; set; }

        [Column("class")]
        public string Class { get; set; }

        //one way or return
        [Column("tripType")]
        public string TripType { get; set; }

        [Column("guestNum")]
        public int GuestNum { get; set; }

        [Column("booked")]
        public bool Booked { get; set; }

        [Column("createdAt")]
        [Required,DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
    }
}
