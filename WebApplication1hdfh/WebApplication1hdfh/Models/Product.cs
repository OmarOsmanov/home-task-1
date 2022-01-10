using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1hdfh.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Title { get; set; }
        [MaxLength(250), Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public decimal Count { get; set; }
    }
}
