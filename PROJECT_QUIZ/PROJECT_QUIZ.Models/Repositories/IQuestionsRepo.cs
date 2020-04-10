using PROJECT_QUIZ.Models.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROJECT_QUIZ.Models.Repositories
{
    public interface IQuestionsRepo
    {
        Task<Questions> Add(Questions question);
        Task DeleteQuestionsByQuiz(Guid id);
        Task<IEnumerable<Questions>> GetQuestionsByQuiz(Guid id);
    }
}