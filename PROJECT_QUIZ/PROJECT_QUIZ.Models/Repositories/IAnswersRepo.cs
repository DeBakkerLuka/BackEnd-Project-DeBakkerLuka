using PROJECT_QUIZ.Models.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROJECT_QUIZ.Models.Repositories
{
    public interface IAnswersRepo
    {
        Task<Answers> Add(Answers answer);
        Task<List<Answers>> GetAnswersByQuestion(Guid id);
    }
}