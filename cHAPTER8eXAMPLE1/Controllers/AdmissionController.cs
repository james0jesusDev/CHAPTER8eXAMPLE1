using cHAPTER8eXAMPLE1.Models;
using Microsoft.AspNetCore.Mvc;

namespace cHAPTER8eXAMPLE1.Controllers
{
    public class AdmissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Decision(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                ACTScoreEvaluator evaluator = new ACTScoreEvaluator();
                applicant.DecisionNote = evaluator.AdmissionEvaluator(applicant);
                return View(applicant);
            }
            return View("Index");


        }
    }
}
