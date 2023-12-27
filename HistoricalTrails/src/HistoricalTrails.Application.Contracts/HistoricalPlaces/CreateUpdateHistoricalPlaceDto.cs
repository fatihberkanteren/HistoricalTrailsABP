using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HistoricalTrails.HistoricalPlaces
{
    public class CreateUpdateHistoricalPlaceDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string History { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
