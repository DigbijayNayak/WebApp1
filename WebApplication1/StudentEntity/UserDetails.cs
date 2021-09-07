using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
    [Table("userdetails")]
    public class UserDetails
    {
        [Key]
        public int User_id { get; set; }
        public string User_name { get; set; }
        public string Email_id { get; set; }
        public string Password { get; set; }
    }
}
