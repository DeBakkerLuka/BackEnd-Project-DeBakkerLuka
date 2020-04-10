using PROJECT_QUIZ.Models.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROJECT_QUIZ.Models.Repositories
{
    public interface IQuizRepo
    {
        Task<Quiz> Add(Quiz quiz);
        Task Delete(Guid id);
        Task<IEnumerable<Quiz>> GetAllQuizzes();
        Task<Quiz> GetForIdAsync(Guid Quizid);
        Task<Questions> GetQuizByQuestionID(Guid id);
    }
}