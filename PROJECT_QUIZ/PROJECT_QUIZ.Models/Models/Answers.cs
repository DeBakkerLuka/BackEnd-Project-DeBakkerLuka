using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class Answers
    {
        public Guid AnswerID { get; set; }
        public Guid QuestionId { get; set; }
        public string AnswerText { get; set; }
        public Boolean Correct { get; set; }
    }
}
