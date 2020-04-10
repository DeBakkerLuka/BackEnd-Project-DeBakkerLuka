using PROJECT_QUIZ.Models.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROJECT_QUIZ.Models.Repositories
{
    public interface IQuestionsRepo
    {
        Task DeleteQuestionsByQuiz(Guid id);
        Task<IEnumerable<Questions>> GetQuestionsByQuiz(Quiz quiz);
    }
}