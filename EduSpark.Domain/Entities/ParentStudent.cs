namespace EduSpark.Domain.Entities;

public class ParentStudent
{
    public int ParentId { get; set; }
    public Parent Parent { get; set; } = null!;

    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
