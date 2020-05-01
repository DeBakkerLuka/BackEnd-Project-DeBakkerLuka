using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;

namespace PROJECT_QUIZ.Controllers
{
    public class QuestionsAnswersController : Controller
    {

        private readonly IQuestionsRepo questionsRepo;
        private readonly IAnswersRepo answersRepo;
        private readonly IHistoryRepo historyRepo;
        private readonly ProjectDBContext context;
        private readonly IQuizRepo quizrepo;

        public QuestionsAnswersController(IQuestionsRepo questionsRepo, ProjectDBContext context, IQuizRepo quizrepo, IAnswersRepo answersRepo, IHistoryRepo historyRepo)
        {
            this.questionsRepo = questionsRepo;
            this.context = context;
            this.quizrepo = quizrepo;
            this.answersRepo = answersRepo;
            this.historyRepo = historyRepo;
        }
        // GET: QuestionsAnswers
        public async Task<ActionResult> IndexAsync(Guid id)
        {
            ViewBag.QuizId = id;
            QuestionsAnswers model = new QuestionsAnswers();
            model.Questions = await questionsRepo.GetQuestionsByQuiz(id);
            List<Answers> list = new List<Answers>();
            foreach (Questions question in model.Questions) {
                foreach (var item in await answersRepo.GetAnswersByQuestion(question.QuestionID)) { list.Add(item); }
            }
            model.Answers = list;
            return View(model);
        }

        // GET: QuestionsAnswers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Education/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, Questions questions, Answers answers)
        {
            try
            {
             

                var created = await questionsRepo.Add(questions);

                if (created == null)
                {
                    throw new Exception("Invalid Entry");
                }
               

                var created2 = await answersRepo.Add(answers);

                if (created2 == null)
                {
                    throw new Exception("Invalid Entry");
                }


                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create geeft error " + ex.Message);
                ModelState.AddModelError("", "Create actie is mislukt voor " + questions.QuestionID);
                return View(questions);
            }

        }

        // GET: QuestionsAnswers
        public async Task<ActionResult> Play(Guid id)
        {
            ViewBag.QuizId = id;
            QuestionsAnswers model = new QuestionsAnswers();
            model.Questions = await questionsRepo.GetQuestionsByQuiz(id);
            List<Answers> list = new List<Answers>();
            foreach (Questions question in model.Questions)
            {
                foreach (var item in await answersRepo.GetAnswersByQuestion(question.QuestionID)) { list.Add(item); }
            }
            model.Answers = list;
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> CatchForm(IFormCollection form) 
        {
            var quizid = Convert.ToString(form["QuizID"]);
            var QuizID = quizid.Split(",").ToList()[0];

            var stringvragen = Convert.ToString(form["QuestionID"]);
            List<string> vragen = stringvragen.Split(",").ToList();
            if (form.Count() != (vragen.Count() + 7))
            {
                throw new Exception("Please fill in all the questions");
                // return RedirectToAction("Play", "QuestionsAnswers", new { id = QuizID });
            }
            else 
            {
                var stringvragentext = Convert.ToString(form["QuestionText"]);
                List<string> StringQuestion = stringvragentext.Split(",").ToList();
                List<string> Iscorrect = new List<string>();
                List<History> Histories = new List<History>();
                for (int i = 0; i < vragen.Count(); i++)
                {
                    var correct = Convert.ToString(form.ElementAt(i + 6));
                    string pattern = @"^(\[){1}(.*?)(\]){1}$";
                    correct = Regex.Replace(correct, pattern, "$2");
                    correct = correct.Trim();
                    var DefCorrect = correct.Split(",");
                    Iscorrect.Add(DefCorrect[1].Trim());
                    History history = new History { QuestionID = Guid.Parse(vragen[i]), Correct = Convert.ToByte(Iscorrect[i]), UserId = User.FindFirstValue(ClaimTypes.NameIdentifier), HistoryID = Guid.NewGuid(), QuestionText = StringQuestion[i], QuizID = Guid.Parse(QuizID) };
                    Histories.Add(history);
                    TempData["Histories"] = JsonConvert.SerializeObject(Histories);
                    var created = await historyRepo.Add(history);
                    if (created == null)
                    {
                        throw new Exception("Invalid Entry");
                    }
                }
                return RedirectToAction("Index", "History", new { length = Histories.Count() });
            } 
        }
    }
}