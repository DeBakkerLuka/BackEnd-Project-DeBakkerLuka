using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class Questions
    {
        public Guid QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string ImageString { get; set; }
        public Guid QuizID { get; set; }
    }
}
