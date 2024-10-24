using Microsoft.AspNetCore.Mvc;

namespace ControlClaimMonthlySystem.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult TrackStatus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TrackStatus(string lecturerName)
        {
            var claim = ClaimController.Claims.FirstOrDefault(c => c.LecturerName == lecturerName);
            if (claim != null)
            {
                ViewBag.Status = claim.Status;
            }
            else
            {
                ViewBag.Message = "Claim not found.";
            }
            return View();
        }
    }
}