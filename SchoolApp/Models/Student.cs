namespace SchoolApp.Models
{
    public class Student
    {
        // The primary key. The database numbers each student by itself.
        public int StudentId { get; set; }
 
        // The ? means "this field may be empty". No rules yet.
        public string? StudentNo { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? Age { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}