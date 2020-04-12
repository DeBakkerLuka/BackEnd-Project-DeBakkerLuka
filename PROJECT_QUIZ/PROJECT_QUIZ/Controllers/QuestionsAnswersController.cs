using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;

namespace PROJECT_QUIZ.Controllers
{
    public class QuestionsAnswersController : Controller
    {

        private readonly IQuestionsRepo questionsRepo;
        private readonly IAnswersRepo answersRepo;
        private readonly ProjectDBContext context;
        private readonly IQuizRepo quizrepo;

        public QuestionsAnswersController(IQuestionsRepo questionsRepo, ProjectDBContext context, IQuizRepo quizrepo, IAnswersRepo answersRepo)
        {
            this.questionsRepo = questionsRepo;
            this.context = context;
            this.quizrepo = quizrepo;
            this.answersRepo = answersRepo;
        }
        // GET: QuestionsAnswers
        public async Task<ActionResult> IndexAsync(Guid id)
        {
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

        // GET: QuestionsAnswers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionsAnswers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionsAnswers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionsAnswers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionsAnswers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionsAnswers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}