using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;

namespace PROJECT_QUIZ.Controllers
{
    public class HistoryController : Controller
    {
        private readonly ProjectDBContext context;
        private readonly IQuestionsRepo questionsRepo;


        public HistoryController(ProjectDBContext context, IQuestionsRepo questionsRepo)
        {
            this.context = context;
            this.questionsRepo = questionsRepo;
        }

        // GET: History
        public ActionResult Index(int length)
        {
            var Json = TempData["Histories"];
            var i = 0;
            List<History> Histories = JsonConvert.DeserializeObject<List<History>>(Json.ToString());
            foreach (History history in Histories) 
            {
                if (history.Correct.ToString() == "1") 
                {
                    i++;
                }
            }
            ViewBag.AchievedScore = i;
            ViewBag.TotalQuestions = Histories.Count();             

            return View(Histories);
        }

        public ActionResult Leaderboard(Guid id)
        {
            // Getting count of all questions in a quiz
            var count = context.Questions.Where(e => e.QuizID == id);
            // Aantal vragen in quiz ophalen
            var users = context.History.Where(e => e.QuizID == id).Select(e => e.UserId).Distinct();
            List<Leaderboard> lijst = new List<Leaderboard>();
            var Histories = context.History.Where(e => e.QuizID == id);
            foreach (string user in users) 
            {      
                var CorrectData = Histories.Where(e => e.UserId == user).ToList();
                List<History> ListHistory = new List<History>();
                for (int i = CorrectData.Count() - 1; i >= CorrectData.Count() - count.Count(); i--)
                {
                    ListHistory.Add(CorrectData[i] );
                }
                var ScorePoints = ListHistory.Where(e => e.Correct == 1).Count();
                var Person = context.Persons.Where(e => e.Id == user).FirstOrDefault();
                string Score = ($"{ScorePoints} / {count.Count()}");
                Leaderboard leaderboard = new Leaderboard { Username = Person.Name, Score = Score };
                lijst.Add(leaderboard);
            }

            return View(lijst);
        }


        // GET: History/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: History/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: History/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: History/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: History/Edit/5
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

        // GET: History/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: History/Delete/5
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