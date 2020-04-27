using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class History
    {
        [Key]
        public Guid HistoryID { get; set; }
        public string UserId { get; set; }
        public Guid QuestionID { get; set; }
        public int PointsGained { get; set; }
        public byte Correct { get; set; }
    }
}
