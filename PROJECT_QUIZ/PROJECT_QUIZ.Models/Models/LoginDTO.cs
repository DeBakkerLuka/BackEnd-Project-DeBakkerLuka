using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class LoginDTO
    {
        [Required] 
        public string UserName { get; set; }
        [Required] 
        public string Password { get; set; }
        public object Birthdate { get; set; }
    }
}
