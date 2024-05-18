﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class CreateRoleDto
    {

        [Required(ErrorMessage = "Roles Name is Required")]
        public string RoleName { get; set; }
    }
}
