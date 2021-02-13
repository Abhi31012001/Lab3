using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Person
    {
        [Required]
        [StringLength(255)]

        public string FirstName
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]

        public string LastName
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]

        public string Age
        {
            get;
            set;
        }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string EmailAddress
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [DataType(DataType.Date)]
        public string Dob
        {
            get;
            set;
        }
        [Required]
        [StringLength(100)]
        [BindProperty(Name = "pass")]
        public string Password
        {
            get;
            set;
        }
        [Required]
        [StringLength(100)]

        public string Description
        {
            get;
            set;
        }
    }
}
