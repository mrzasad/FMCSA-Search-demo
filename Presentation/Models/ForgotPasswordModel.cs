﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class ForgotPasswordModel
    {

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; } 
    }
}
