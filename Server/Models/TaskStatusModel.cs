using Server.Enums;

namespace Server.Models
{
    public class TaskStatusModel
    {
        public int Id { get; set; }
        public StatusType Status { get; set; }
        public string? DisplayName { get; set; }
    }
}
