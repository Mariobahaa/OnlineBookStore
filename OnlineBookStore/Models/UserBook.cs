using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class UserBook
    {
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public string UserId { get; set; }
     
        [Range(0,10)]
        public int Rating { get; set; }
    }
}


/*
 *          Buys-> 
 * User                 Book
 *          Rates->   
 *          | Rating
 * 
    UserId [key], Book (Book Id) [key]
 */

