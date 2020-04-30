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
    public class HistoryRepo : IHistoryRepo
    {
        private readonly ProjectDBContext context;

        public HistoryRepo(ProjectDBContext context)
        {
            this.context = context;
        }



        public async Task<IEnumerable<History>> GetAllHistory()
        {
            var items = await context.History.ToListAsync();
            return items;
        }

        public async Task<History> GetHistoryForID(Guid id)
        {
            var query = context.History.Where(e => e.HistoryID == id);
            History result = await query.SingleOrDefaultAsync();
            return result;
        }


        public async Task<History> Add(History history)
        {
            try
            {
                var result = context.History.AddAsync(history); // Change Tracking
                await context.SaveChangesAsync(); // Dit is een MUST
                //return result;  // NOK
                return history; // OK - ByRef -> De server returnt uw object education + een autoIdentity!
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // Niet vergeten!
            }
        }

        public async Task Delete(Guid id)
        {
            try
            {
                History history = await context.History.FindAsync(id);
                var result = context.History.Remove(history); //beter is hier te archiveren
                await context.SaveChangesAsync();
            }

            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            return;
        }
    }
}
