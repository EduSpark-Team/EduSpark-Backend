namespace EduSpark.Domain.Entities;

public class Parent
{
    public int Id { get; set; }

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    public ICollection<ParentStudent> ParentStudents { get; set; } = new List<ParentStudent>();
}
