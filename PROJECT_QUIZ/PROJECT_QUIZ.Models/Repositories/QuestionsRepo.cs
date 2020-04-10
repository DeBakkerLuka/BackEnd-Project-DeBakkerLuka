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
    public class QuestionsRepo : IQuestionsRepo
    {
        private readonly ProjectDBContext context;
        public QuestionsRepo(ProjectDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Questions>> GetQuestionsByQuiz(Quiz quiz)
        {
            var query = context.Questions.Where(e => e.QuizID == quiz.QuizID);
            IEnumerable<Questions> result = await query.ToListAsync();
            return result;
        }
        public async Task DeleteQuestionsByQuiz(Guid id)
        {
            try
            {
                var query = context.Questions.Where(e => e.QuizID == id);
                IEnumerable<Questions> result = await query.ToListAsync();
                foreach (Questions question in result)
                {
                    var delete = context.Questions.Remove(question);
                    await context.SaveChangesAsync();
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
            return;
        }

    }
}
