using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class Questions
    {
        [Required]
        [Display(Name = "Vraag ID")]
        public Guid QuestionID { get; set; }
        [Display(Name = "Vraag Tekst")]
        [Required]
        public string QuestionText { get; set; }
        [Display(Name = "Foto Uploaden")]
        [NotMapped]
        public IFormFile ImageString { get; set; }
        [Display(Name = "Quiz ID")]
        [Required]
        public Guid QuizID { get; set; }
    }
}
