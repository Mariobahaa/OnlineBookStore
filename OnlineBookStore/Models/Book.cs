using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title {get; set;}

        [Required]
        [MaxLength(50)]
        public string Author {get; set;}

        [Range(0,10000)]
        [DefaultValue(0)]
        public float Price {get; set;}

        [DataType(DataType.Date)]
        public DateTime PubDate {get; set;}

        [Required]
        public Genre Genre {get; set;}


        public List<UserBook> UserBook { get; set; }
    }
}
