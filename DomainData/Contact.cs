using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainData
{
    [Table("Contact")]
    public class Contact : BaseEntity
    {
        public int UserId { get; set; }
        public int AdminId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("AdminId")]
        public virtual User Admin { get; set; }
    }
}
