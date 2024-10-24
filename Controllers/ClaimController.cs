using ControlClaimMonthlySystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ControlClaimMonthlySystem.Controllers
{
    public class ClaimController : Controller
    {
        public static List<LecturerClaimModel> Claims = new List<LecturerClaimModel>();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LecturerClaimModel claim)
        {
            if (ModelState.IsValid)
            {
                Claims.Add(claim);
                ViewBag.Message = "Claim Submitted Successfully!";
            }
            return View();
        }

        public IActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitClaim(LecturerClaimModel claim, IFormFile uploadedFile)
        {
            if (uploadedFile != null && uploadedFile.Length > 0)
            {
                // Save the uploaded file logic (in-memory simulation)
                claim.UploadedDocument = uploadedFile.FileName;
                Claims.Add(claim);
                ViewBag.Message = "Claim submitted successfully!";
            }
            return View();
        }
    }
}