﻿using System;
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
    public class QuestionsController : Controller
    {
        private readonly IQuestionsRepo questionsRepo;
        private readonly ProjectDBContext context;
        private readonly IQuizRepo quizrepo;

        public QuestionsController(IQuestionsRepo questionsRepo, ProjectDBContext context, IQuizRepo quizrepo)
        {
            this.questionsRepo = questionsRepo;
            this.context = context;
            this.quizrepo = quizrepo;
        }
        // GET: Questions
        public async Task<ActionResult> IndexAsync(Guid id)
        {
            ViewBag.Quizid = id;
            return View(await questionsRepo.GetQuestionsByQuiz(id));
            
        }

        // GET: Questions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Questions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Questions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, Questions question, Guid id)
        {
            try
            {

                question.QuizID = id;
                question.QuestionID = Guid.NewGuid();
                
                if (question.ImageString == "")
                {
                    question.ImageString = null;
                }
                var created = await questionsRepo.Add(question);
                if (created == null)
                {
                    throw new Exception("Invalid Entry");
                }
                return RedirectToAction("Index", new { id = id });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create geeft error " + ex.Message);
                ModelState.AddModelError("", "Create actie is mislukt voor " + question.QuestionID);
                return View(question);
            }

        }

        // GET: Questions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Questions/Edit/5
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

        // GET: Questions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Questions/Delete/5
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