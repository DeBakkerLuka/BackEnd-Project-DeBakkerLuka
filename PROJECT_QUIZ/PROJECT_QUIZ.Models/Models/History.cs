using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class History
    {
        public Guid HistoryID { get; set; }
        public string UserID { get; set; }
        public Guid QuestionID { get; set; }
        public int PointsGained { get; set; }
        public string Answer { get; set; }
        public Boolean Correct { get; set; }
    }
}
