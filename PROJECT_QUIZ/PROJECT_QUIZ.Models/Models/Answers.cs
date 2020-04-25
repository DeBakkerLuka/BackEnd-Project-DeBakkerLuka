using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Byte Correct { get; set; }
    }
}
