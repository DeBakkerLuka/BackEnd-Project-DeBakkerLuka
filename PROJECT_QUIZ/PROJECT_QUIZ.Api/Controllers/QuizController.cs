﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;

namespace PROJECT_QUIZ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly ProjectDBContext context;
        private readonly IQuizRepo quizRepo;

        public QuizController(ProjectDBContext context, IQuizRepo quizRepo)
        {
            this.context = context;
            this.quizRepo = quizRepo;
        }

        // GET: api/Quiz
        [HttpGet(Name = "GetAllQuizzes")]
        [EnableCors("AllowOrigin")]
        public async Task<IEnumerable<Quiz>> GetAllAsync()
        {
            return await quizRepo.GetAllQuizzes();
        }

        // GET: api/Quiz/5
        [HttpGet("{id}", Name = "GetQuizByID")]
        [EnableCors("AllowOrigin")]
        public async Task<Quiz> GetAsync(Guid id)
        {
            return await quizRepo.GetForIdAsync(id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [EnableCors("AllowOrigin")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await quizRepo.Delete(id);
            return Ok("DELETE was succesfull");
        }
    }
}
