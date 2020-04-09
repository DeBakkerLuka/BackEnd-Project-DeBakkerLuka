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
        public Guid QuizID { get; set; }
        public String UserID { get; set; }
        public string QuizName { get; set; }
        public string Subject { get; set; }
        public string Difficulty { get; set; }

    }
}
