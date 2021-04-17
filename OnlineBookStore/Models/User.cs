using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookStore.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public UserBook UserBook { get; set; }
    }
}
