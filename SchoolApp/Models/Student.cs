using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        // Student number
        [Display(Name = "Student No.")]
        [Required(ErrorMessage = "Please enter the student number.")]
        // ^ start, \d{4} four digits, - a dash, \d{4} four digits, $ end
        [RegularExpression(@"^\d{4}-\d{4}$", ErrorMessage = "Use the format 2026-0001.")]
        public string? StudentNo { get; set; }



        // Name validation
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please enter the student's name. - Meliz Alyana")]
        [StringLength(100, ErrorMessage = "The name can't be longer than 100 characters.")]
        public string? Name { get; set; }

        // Email validation
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email, like melizalyana@example.com.")]
        public string? Email { get; set; }

        // Phone validation
        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string? Phone { get; set; }

        // Age validation
        [Range(16, 60, ErrorMessage = "Age must be from 16 to 60.")]
        public int? Age { get; set; }

        // Birth date
        public DateTime? BirthDate { get; set; }
    }
}