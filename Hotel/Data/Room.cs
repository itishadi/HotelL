using System.ComponentModel.DataAnnotations;

namespace Hotel.Data
{
    public class Room
    {
        [Key ]
        [Required]
        [MaxLength(10)]
        public string RoomId{ get; set; }
        public string Type{ get; set; }
        public string Description { get; set; }
        public string ExtraBed { get; set; }
      
    }
}