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
        private readonly IAnswersRepo answersRepo;

        public QuestionsRepo(ProjectDBContext context, IAnswersRepo answersRepo)
        {
            this.context = context;
            this.answersRepo = answersRepo;
        }

        public async Task<IEnumerable<Questions>> GetAllQuestions()
        {
            var items = await context.Questions.ToListAsync();
            return items;
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

        public async Task<Questions> GetQuestionByIdAsync(Guid QuestionId)
        {
            var result = await context.Questions.AsNoTracking().SingleOrDefaultAsync<Questions>(e => e.QuestionID == QuestionId);
            return result;
        }

        public async Task Delete(Guid id)
        {
            try
            {
                List<Answers> list = await answersRepo.GetAnswersByQuestion(id);
                foreach (Answers item in list)
                {
                    var deleteAnswers = context.Answers.Remove(item);
                    await context.SaveChangesAsync();
                }
                Questions question = await context.Questions.FindAsync(id);
                var result = context.Questions.Remove(question); //beter is hier te archiveren

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
