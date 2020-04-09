using System;
using System.Collections.Generic;
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

        public QuizController(IQuizRepo quizrepo, ProjectDBContext context, UserManager<Person> UserMgr)
        {
            this.quizrepo = quizrepo;
            this.context = context;
            _userManager = UserMgr;
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quiz/Edit/5
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

        // GET: Quiz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Quiz/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}