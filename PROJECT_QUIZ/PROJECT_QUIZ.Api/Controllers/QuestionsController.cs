using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;

namespace PROJECT_QUIZ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsRepo questionsRepo;
        private const string AuthSchemes = CookieAuthenticationDefaults.AuthenticationScheme + ",Identity.Application";

        public QuestionsController(IQuestionsRepo questionsRepo)
        {
            this.questionsRepo = questionsRepo;
        }

        [HttpGet(Name = "GetAllQuestions")]
        [Authorize(AuthenticationSchemes = AuthSchemes, Roles = "Admin")]
        public async Task<IEnumerable<Questions>> GetAllQuestions()
        {
            return await questionsRepo.GetAllQuestions();
        }

        // GET: api/Questions/5
        [HttpGet("{id}", Name = "GetQuestionByID")]
        [Authorize(AuthenticationSchemes = AuthSchemes, Roles = "Admin")]
        public Task<Questions> Get(Guid id)
        {
            return questionsRepo.GetQuestionByIdAsync(id);
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = AuthSchemes, Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await questionsRepo.Delete(id);
            return Ok("DELETE was succesfull");
        }
    }
}
