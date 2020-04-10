using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class Quiz
    {
        [Key]
        [Display(Name = "Quiz ID")]
        public Guid QuizID { get; set; }
        [Display(Name = "Gebruikers ID")]
        public String UserID { get; set; }
        [Display(Name = "Quiz Naam")]
        [Required(ErrorMessage = "Verplichte Naam input")]
        public string QuizName { get; set; }
        [Display(Name = "Onderwerp")]
        [Required(ErrorMessage = "Verplichte Onderwerp input")]
        public string Subject { get; set; }
        [Display(Name = "Moeilijkhijdsgraad")]
        public string Difficulty { get; set; }

    }
}
