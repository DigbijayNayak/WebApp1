using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("student")]
    public class StudentEntity
    {
        [Key]    //
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
    }
}
