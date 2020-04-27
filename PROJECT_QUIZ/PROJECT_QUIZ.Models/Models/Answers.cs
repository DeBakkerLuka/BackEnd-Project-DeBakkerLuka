using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class Answers
    {
        [Display(Name = "Antwoord ID")]
        public Guid AnswerID { get; set; }
        [Display(Name = "Vraag ID")]
        public Guid QuestionId { get; set; }
        [Display(Name = "Antwoord Tekst")]
        public string AnswerText { get; set; }
        [Display(Name = "Correct? ")]
        [Column("Correct")]
        public byte Correct { get; set; }
        [Display(Name = "Geselecteerd ")]
        [Column("Selected")]
        [BindProperty]
        public bool Selected { get; set; }
    }
}
