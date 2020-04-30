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
    public class AnswersController : ControllerBase
    {
        private readonly IAnswersRepo answerrepo;

        public AnswersController(IAnswersRepo answerrepo)
        {
            this.answerrepo = answerrepo;
        }

        // GET: api/Answers
        [HttpGet(Name = "GetAllAnswers")]
        [EnableCors("AllowOrigin")]
        public async Task<IEnumerable<Answers>> GetAsync()
        {
            return await answerrepo.GetAllAnswers();
        }

        // GET: api/Answers/5
        [HttpGet("{id}", Name = "GetAnswerByID")]
        [EnableCors("AllowOrigin")]
        public async Task<Answers> GetAsync(Guid id)
        {
            return await answerrepo.GetForIdAsync(id);
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [EnableCors("AllowOrigin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await answerrepo.Delete(id);
            return Ok("DELETE was succesfull");
        }
    }
}
