namespace Server.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Comments { get; set; }
        public TaskStatus? Status { get; set; }
    }
}
