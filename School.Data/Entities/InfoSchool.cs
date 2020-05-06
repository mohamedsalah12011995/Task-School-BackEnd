using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.Data.Entities
{
    public class SchoolInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }
        public int CountDay { get; set; }

    }
}


