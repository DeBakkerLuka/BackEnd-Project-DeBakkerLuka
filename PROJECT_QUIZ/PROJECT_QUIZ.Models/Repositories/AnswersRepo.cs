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
    public class AnswersRepo : IAnswersRepo
    {
        private readonly ProjectDBContext context;
        public AnswersRepo(ProjectDBContext context)
        {
            this.context = context;
        }

        public async Task<List<Answers>> GetAllAnswers()
        {
            var query = await context.Answers.ToListAsync();
            return query;
        }

        public async Task<List<Answers>> GetAnswersByQuestion(Guid id)
        {
            var query = context.Answers.Where(e => e.QuestionId == id);
            List<Answers> result = await query.ToListAsync();
            return result;
        }

        public async Task<Answers> Add(Answers answer)
        {
            try
            {
                var result = context.Answers.AddAsync(answer); // Change Tracking
                await context.SaveChangesAsync(); // Dit is een MUST
                //return result;  // NOK
                return answer; // OK - ByRef -> De server returnt uw object education + een autoIdentity!
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // Niet vergeten!
            }
        }

        public async Task<Answers> GetForIdAsync(Guid AnswerId)
        {
            var result = await context.Answers.AsNoTracking().SingleOrDefaultAsync<Answers>(e => e.AnswerID == AnswerId);
            return result;
        }


        public async Task Delete(Guid id)
        {
            try
            {
                Answers answer = await context.Answers.FindAsync(id);
                if (answer == null)
                {
                    return;
                }
                var result = context.Answers.Remove(answer);
                await context.SaveChangesAsync();
            }

            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            return;


        }

        public async Task<Answers> GetAnswerByAnswerID(Guid id)
        {
            var query = context.Answers.Where(e => e.AnswerID == id);
            Answers result = await query.SingleOrDefaultAsync();
            return result;
        }
    }
}
