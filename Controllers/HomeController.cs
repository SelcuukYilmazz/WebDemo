using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddUsers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUsers(UserModel user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DemoContext())
                {
                    db.Add(user);
                    db.SaveChanges();
                }

            }
            

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DemoContext())
                {
                    var result = db.Users.Where(u => u.Name.Contains(user.Name)).FirstOrDefault();
                    if(user.Name == result.Name && user.Password == result.Password)
                    {
                        List<QuizModel> quizzes = new List<QuizModel>();
                        quizzes = db.Quiz.ToList();

                        
                        ViewBag.quizzes = quizzes;

                        return View("QuizList");
                    }
                }

            }


            return View();
        }

        public IActionResult MainScreen()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MainScreen(QuizModel quiz)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DemoContext())
                {

                    db.Add(quiz);
                    db.SaveChanges();

                }

            }


            return View();
        }

        public IActionResult QuizList()
        {

            List<QuizModel> quizzes = new List<QuizModel>();
            using (var db = new DemoContext())
            {
                quizzes = db.Quiz.ToList();

            }
            ViewBag.quizzes = quizzes;

                return View();
        }

        [HttpPost]
        public IActionResult QuizList(QuizModel quiz)
        {
            return View("MainScreen");
        }

        [HttpPost]
        public IActionResult DeleteQuiz(QuizModel quiz)
        {
            List<QuizModel> quizzes = new List<QuizModel>();
            using (var db = new DemoContext())
            {

                var result = db.Quiz.Remove(db.Quiz.Where(u => u.Id == quiz.Id).FirstOrDefault());
                db.SaveChanges();

                quizzes = db.Quiz.ToList();

            }
            ViewBag.quizzes = quizzes;

            return View("QuizList");
        }
        [HttpPost]
        public IActionResult SolveQuiz(QuizModel quiz)
        {
            List<QuizModel> quizzes = new List<QuizModel>();
            using (var db = new DemoContext())
            {

                var result = db.Quiz.Where(u => u.Id == quiz.Id).FirstOrDefault();
                
                ViewBag.quiz = result;
            }

            return View("SolveQuiz");
        }

        [HttpPost]
        public IActionResult CheckQuiz(QuizModel userQuiz)
        {
            

            List<ResultModel> results = new List<ResultModel>();
            using (var db = new DemoContext())
            {
                var realQuiz = db.Quiz.Where(u => u.Id == userQuiz.Id).FirstOrDefault();
                var user = db.Users.Where(u => u.Id == userQuiz.UserId).FirstOrDefault();
                
                int grade = 0;
                if(userQuiz.Answer1 == realQuiz.Answer1)
                {
                    grade += 25;
                }
                if (userQuiz.Answer2 == realQuiz.Answer2)
                {
                    grade += 25;
                }
                if (userQuiz.Answer3 == realQuiz.Answer3)
                {
                    grade += 25;
                }
                if (userQuiz.Answer4 == realQuiz.Answer4)
                {
                    grade += 25;
                }

                ResultModel resultModel = new ResultModel(user.Id,userQuiz.Id,user.Name,grade);
                db.Add(resultModel);
                db.SaveChanges();
                
                results = db.Result.ToList();

            }
            ViewBag.results = results;

            return View("Result");
        }

        public IActionResult Result()
        {

            List<ResultModel> results = new List<ResultModel>();
            using (var db = new DemoContext())
            {
                results = db.Result.ToList();
            }
            ViewBag.results = results;
            return View("Result");
        }
    }
}
