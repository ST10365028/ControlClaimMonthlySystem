using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ControlClaimMonthlySystem.Models
{
    public class LecturerClaimModel
    {
        [Required]
        public string LecturerName { get; set; }

        [Required]
        public string Module { get; set; }

        [Required]
        public int HoursWorked { get; set; }

        [Required]
        public decimal HourlyRate { get; set; }

        public string UploadedDocument { get; set; }

        public string Status { get; set; } = "Pending"; // Default status
    }
}
