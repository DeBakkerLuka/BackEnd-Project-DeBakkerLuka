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
            ViewBag.QuizID = Histories[0].QuizID;
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
                Leaderboard leaderboard = new Leaderboard { Username = Person.UserName, Score = Score };
                lijst.Add(leaderboard);
            }
            List<Leaderboard> SortedList = lijst.OrderByDescending(o => o.Score).ToList();
            return View(SortedList);
        }
    }
}