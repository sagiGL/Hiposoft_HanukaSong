using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hiposoft_HanukaSong.Models
{
    public class Song
    {
        [Key]
        [Required]
        [RegularExpression("^[0-9]")]
        public string Number { get; set; }

        [Required]
        [StringLength(50,MinimumLength =2, ErrorMessage = "Length must be between 2 and 50 characthers")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 50 characthers")]
        public string WriterName { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 1000 characthers")]
        public string Lyrics { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 100 characthers")]
        public string YouTubeLink { get; set; }
    }
}