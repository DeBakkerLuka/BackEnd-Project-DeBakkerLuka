using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;

namespace PROJECT_QUIZ.Controllers
{
    public class AnswersController : Controller
    {
        private readonly IQuestionsRepo questionsRepo;
        private readonly ProjectDBContext context;
        private readonly IQuizRepo quizrepo;
        private readonly IAnswersRepo answerRepo;

        public AnswersController(IQuestionsRepo questionsRepo, ProjectDBContext context, IQuizRepo quizrepo, IAnswersRepo answerRepo)
        {
            this.questionsRepo = questionsRepo;
            this.context = context;
            this.quizrepo = quizrepo;
            this.answerRepo = answerRepo;
        }

        // GET: Answers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Answers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Answers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Answers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(IFormCollection collection, Answers answer, Guid id)
        {
            answer.AnswerID = Guid.NewGuid();
            answer.QuestionId = id;
            var quiz = await quizrepo.GetQuizByQuestionID(id);
            
            

            try
            {
                var created = await answerRepo.Add(answer);
                if (created == null)
                {
                    throw new Exception("Invalid Entry");
                }
                return RedirectToAction("Index", "QuestionsAnswers", new { id = quiz.QuizID });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create geeft error " + ex.Message);
                ModelState.AddModelError("", "Create actie is mislukt voor " + answer.AnswerID);
                return View(answer);
            }
        }

        // GET: Answers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Answers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Answers/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var answer = await answerRepo.GetForIdAsync(id);
            if (answer == null)
            {
                return NotFound();
            }
            return View(answer);
        }

        // POST: Answers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Guid id, IFormCollection collection)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("Bad Delete Request.");
                }
                Answers antwoord = await answerRepo.GetAnswerByAnswerID(id);
                Questions question = await quizrepo.GetQuizByQuestionID(antwoord.QuestionId);
                await answerRepo.Delete(id);
                
                return RedirectToAction("Index", "QuestionsAnswers", new { id = question.QuizID });
            }
            catch (Exception)
            {
                Debug.WriteLine($"Delete error. ");
                ModelState.AddModelError(String.Empty, "Delete failed.");
                return View();
            }
        }
    }
}