using Microsoft.EntityFrameworkCore;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_QUIZ.Models.Repositories
{
    public class QuizRepo : IQuizRepo
    {
        private readonly ProjectDBContext context;
        public QuizRepo(ProjectDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Quiz>> GetAllQuizzes()
        {
            return await context.Quizzes.ToListAsync<Quiz>();
                
        }
    }
}
