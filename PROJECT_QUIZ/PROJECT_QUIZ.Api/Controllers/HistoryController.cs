using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;

namespace PROJECT_QUIZ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryRepo historyRepo;

        public HistoryController(IHistoryRepo historyRepo)
        {
            this.historyRepo = historyRepo;
        }

        // GET: api/History
        [HttpGet(Name = "Histories")]
        [EnableCors("AllowOrigin")]
        public async Task<IEnumerable<History>> GetAsync()
        {
            return await historyRepo.GetAllHistory();
        }

        // GET: api/History/5
        [HttpGet("{id}", Name = "GetHistoryByID")]
        [EnableCors("AllowOrigin")]
        public async Task<History> GetAsync(Guid id)
        {
            return await historyRepo.GetHistoryForID(id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [EnableCors("AllowOrigin")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await historyRepo.Delete(id);
            return Ok("DELETE was succesfull");
        }
    }
}
