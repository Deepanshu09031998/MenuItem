using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing
{
    public class MenuItem
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Free Delivery")]
        public bool freeDilivery { get; set; }
        [Required]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateOfLaunch { get; set; }
        public bool Active { get; set; }
    }
}
