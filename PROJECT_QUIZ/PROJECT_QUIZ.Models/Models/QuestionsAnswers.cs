using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class QuestionsAnswers
    {
        public IEnumerable<Questions> Questions { get; set; }
        public IEnumerable<Answers> Answers { get; set; }
    }
}
