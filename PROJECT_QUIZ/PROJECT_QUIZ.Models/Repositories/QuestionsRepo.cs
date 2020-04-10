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

        public async Task<IEnumerable<Questions>> GetQuestionsByQuiz(Guid id)
        {
            var query = context.Questions.Where(e => e.QuizID == id);
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

        public async Task<Questions> Add(Questions question)
        {
            try
            {
                var result = context.Questions.AddAsync(question); // Change Tracking
                await context.SaveChangesAsync(); // Dit is een MUST
                //return result;  // NOK
                return question; // OK - ByRef -> De server returnt uw object education + een autoIdentity!
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // Niet vergeten!
            }
        }

    }
}
