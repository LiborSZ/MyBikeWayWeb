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
        public string Name { get; set; }
        /// <summary>
        /// Latitude geographic coordinate
        /// </summary>
        public double Latitude { get; set; }
        /// <summary>
        /// Longtitude geographic coordinate
        /// </summary>
        public double Longtitude { get; set; }

    }
}
