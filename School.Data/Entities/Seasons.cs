﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.Data.Entities
{
    public class Seasons
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}


