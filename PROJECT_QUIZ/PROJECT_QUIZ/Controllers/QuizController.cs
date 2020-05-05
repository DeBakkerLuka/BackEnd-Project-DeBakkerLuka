using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;

namespace PROJECT_QUIZ.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuizRepo quizrepo;
        private readonly ProjectDBContext context;
        public UserManager<Person> _userManager;
        private readonly IQuestionsRepo questionsRepo;

        public QuizController(IQuizRepo quizrepo, ProjectDBContext context, UserManager<Person> UserMgr, IQuestionsRepo questionsRepo)
        {
            this.quizrepo = quizrepo;
            this.context = context;
            _userManager = UserMgr;
            this.questionsRepo = questionsRepo;
        }

        public async Task<ActionResult> RateQuizAsync(Guid id)
        {
            ViewBag.QuizID = id;
            Console.WriteLine(id);
            Quiz quiz = await quizrepo.GetQuizForID(id);
            Console.WriteLine(id);
            return View(quiz);
        }

        public async Task<ActionResult> CatchRating(IFormCollection lijst)
        {
            Guid quizid = Guid.Parse(lijst["QuizID"]);
            Quiz quiz = await quizrepo.GetQuizForID(quizid);
            var rating = Convert.ToString(lijst["Rating"]);
            quiz.Rating = rating;
            // await quizrepo.Delete(quizid);
            await quizrepo.Update(quiz);
            return RedirectToAction(nameof(Index));
        }

        // GET: Quiz
        public async Task<ActionResult> IndexAsync()
        {
            return View(await quizrepo.GetAllQuizzes());
        }

        // GET: Quiz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Education/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quiz/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, Quiz quiz)
        {
            try
            {
                quiz.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                quiz.QuizID = Guid.NewGuid();
                
                var created = await quizrepo.Add(quiz);
                if (created == null)
                {
                    throw new Exception("Invalid Entry");
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create geeft error " + ex.Message);
                ModelState.AddModelError("", "Create actie is mislukt voor " + quiz.QuizName);
                return View(quiz);
            }

        }



        // GET: Quiz/Edit/5
        public async Task<ActionResult> EditAsync(Guid id)
        {
            if (id == null)
            {
                //return BadRequest();  //model nog null
                return Redirect("/Error/400");
            }
            var quiz = await quizrepo.GetQuizForID(id);
            if (quiz == null)
            {
                //return BadRequest();  //ADO
                ModelState.AddModelError("", "Not Found.");
            }
            return View(quiz);
        }

        // POST: Quiz/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(Guid id, IFormCollection collection, Quiz quiz)
        {
            try
            {
                // TODO: Add update logic here
                if (id == null)
                {
                    return BadRequest();
                }
                var result = await quizrepo.Update(quiz);
                if (result == null)
                {
                    //throw new Exception(" Not Found.");
                    return Redirect("/Error/400");
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception exc)
            {
                ModelState.AddModelError("", "Update actie mislukt." + exc.Message);

                return View(quiz);
            }
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var teacher = await quizrepo.GetForIdAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        // POST: Teacher/Delete/5
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
                IEnumerable<Questions> list = await questionsRepo.GetQuestionsByQuiz(id);
                foreach(Questions question in list)
                {
                    await questionsRepo.Delete(question.QuestionID);
                }
                await quizrepo.Delete(id); 
                return RedirectToAction(nameof(Index));
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