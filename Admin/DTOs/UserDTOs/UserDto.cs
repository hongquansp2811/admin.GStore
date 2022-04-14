using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Admin.DTOs
{
    public class UserDto
    {
        public int Id { get; set; } 

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public int? Phone { get; set; }

        public byte? Gender { get; set; }

        public byte? Status { get; set; }

        public byte? Access { get; set; }
    }
}