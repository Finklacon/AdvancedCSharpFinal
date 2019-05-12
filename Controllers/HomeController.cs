using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSC237_JFink_Final2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSC237_JFink_Final2.Controllers
{
    public class HomeController : Controller
    {
      

            private readonly IGolferRepository _golferRepository;
            private readonly IScoreRepository _scoreRepository;
            private readonly IDistanceRepository _distanceRepository;

            public HomeController(IGolferRepository golferRepository, IScoreRepository scoreRepository, IDistanceRepository distanceRepository)
            {
                _golferRepository = golferRepository;
                _scoreRepository = scoreRepository;
                _distanceRepository = distanceRepository;
            }
       
            public ViewResult Index() => View(_golferRepository.GetGolfers);

            public ViewResult AddGolfer() => View();
            public ViewResult AddScore() => View();
            // GET: /<controller>/

            [HttpPost]
            public IActionResult AddGolfer(Golfer golfer)
            {
                _golferRepository.AddGolfer(golfer);
                return RedirectToAction("GolferManagement");
            }

            [HttpGet]
            public IActionResult GolferManagement()
            {
                var golfers = _golferRepository.GetGolfers;
                if (golfers == null)
                    return NotFound();

                return View(golfers);
            }

            [HttpPost]
            public IActionResult AddScore(Scores score)
            {
                _scoreRepository.AddScore(score);
                return RedirectToAction("ScoreManagement");
            }
            [HttpGet]
            public IActionResult ScoreManagement()
            {
                var scores = _scoreRepository.GetScores;
                if (scores == null)
                    return NotFound();

                return View(scores);
            }

            [HttpGet]
            public IActionResult DistanceManagement()
             {
                var distances = _distanceRepository.GetDistance();
                if (distances == null)
                return NotFound();

                return View(distances);
             }

            public IActionResult Login()
            {
                return View();
            }

    }
}
