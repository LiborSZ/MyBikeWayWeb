using System.ComponentModel.DataAnnotations;

namespace MyBikeWayWeb.Models
{
    public class Location
    {
        /// <summary>
        /// Database index
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Location name
        /// </summary>
        [Required]
        [MaxLength(60,ErrorMessage = "Name is too long")]
        public string Name { get; set; }
        /// <summary>
        /// Latitude geographic coordinate
        /// </summary>
        [Required]
        public double Latitude { get; set; }
        /// <summary>
        /// Longtitude geographic coordinate
        /// </summary>
        [Required]
        public double Longtitude { get; set; }

    }
}
