using PROJECT_QUIZ.Models.Models;
using System;
using System.Threading.Tasks;

namespace PROJECT_QUIZ.Models.Repositories
{
    public interface IHistoryRepo
    {
        Task<History> Add(History history);
        Task Delete(Guid id);
    }
}