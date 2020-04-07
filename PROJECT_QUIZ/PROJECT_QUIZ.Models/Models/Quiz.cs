using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class Quiz
    {
        public Guid QuizID { get; set; }
        public string UserID { get; set; }
        public string Subject { get; set; }
        public string Difficulty { get; set; }
    }
}
