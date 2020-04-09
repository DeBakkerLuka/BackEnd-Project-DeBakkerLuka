using PROJECT_QUIZ.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROJECT_QUIZ.Models.Repositories
{
    public interface IQuizRepo
    {
        Task<IEnumerable<Quiz>> GetAllQuizzes();
        Task<Quiz> Add(Quiz quiz);
    }
}