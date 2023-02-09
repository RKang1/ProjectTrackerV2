using Server.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class StatusModel
    {
        [Key]
        [Column("Id")]
        public StatusType StatusType { get; set; }
        public string? DisplayName { get; set; }
    }
}
