﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIDatabaseFirst.DTOs.Request
{
    public class PromoteStudentsRequest
    {
        [Required]
        public string Studies { get; set; }

        [Required]
        public int Semester { get; set; }

    }
}
