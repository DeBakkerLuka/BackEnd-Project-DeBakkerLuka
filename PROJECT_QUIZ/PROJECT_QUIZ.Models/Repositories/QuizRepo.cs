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
            var items = await context.Quiz.ToListAsync();
            return items;
        }

        public async Task<Quiz> Add(Quiz quiz)
        {
            try
            {
                var result = context.Quiz.AddAsync(quiz); // Change Tracking
                await context.SaveChangesAsync(); // Dit is een MUST
                //return result;  // NOK
                return quiz; // OK - ByRef -> De server returnt uw object education + een autoIdentity!
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // Niet vergeten!
            }
        }

        public async Task<Quiz> GetForIdAsync(Guid Quizid)
        {
            var result = await context.Quiz.AsNoTracking().SingleOrDefaultAsync<Quiz>(e => e.QuizID == Quizid);
            return result;
        }


        public async Task Delete(Guid id)
        {
            try
            {
                Quiz quiz = await context.Quiz.FindAsync(id);
                if (quiz == null)
                {
                    return;
                }
                var result = context.Quiz.Remove(quiz); //beter is hier te archiveren
                await context.SaveChangesAsync();
            }
            //return result.Entity.Id 

            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            return;
        }
    }
}
