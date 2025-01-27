using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Entities
{
    public class Shop
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name field is required")]
        [StringLength(maximumLength:100)]
        public required string Name { get; set; }
        public Point Location { get; set; }
    }
}
