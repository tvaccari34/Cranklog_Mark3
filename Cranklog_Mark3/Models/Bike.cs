using Cranklog_Mark3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrankLog_Mark3.Models
{
    public class Bike
    {
        [Key]
        public int bikeId { get; set; }

        [DisplayName("Frame Number")]
        [Required(ErrorMessage = "The frame number is required")]
        [StringLength(80)]
        public string bikeFrameNumber { get; set; }

        [DisplayName("Brand")]
        [Required(ErrorMessage = "Brand is required")]
        [StringLength(50)]
        public string bikeBrand { get; set; }

        [DisplayName("Model")]
        [Required(ErrorMessage = "Model is required")]
        [StringLength(50)]
        public string bikeMode { get; set; }

        [DisplayName("Color")]
        [Required(ErrorMessage = "Color is required")]
        [StringLength(20)]
        public string bikeColoer { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal bikePrice { get; set; }

    }

    
}