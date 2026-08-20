namespace WebApplication1.Models.Dtos
{
    public class AddEmployeeDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public required string Salary { get; set; }
    }
}
