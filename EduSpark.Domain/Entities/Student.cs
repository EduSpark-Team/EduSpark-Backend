namespace EduSpark.Domain.Entities;

public class Student
{
    public int Id { get; set; }

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    public string StudentCode { get; set; } = string.Empty;

    public int GradeId { get; set; }
    public Grade Grade { get; set; } = null!;

    public ICollection<ParentStudent> ParentStudents { get; set; } = new List<ParentStudent>();
}
