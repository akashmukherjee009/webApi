namespace WebApplication1.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set;  }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public required string Salary { get; set; }
    }
}

