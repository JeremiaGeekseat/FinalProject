using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainData
{
    [Table("Favorite")]
    public class Favorite : BaseEntity
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }

        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}
