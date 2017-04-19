using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ReleaseDate { get; set; }

        public string DataAdded { get; set; }

        public byte GenreId { get; set; }

        public byte NumberInStock { get; set; }
    }
}