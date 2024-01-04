using System.ComponentModel.DataAnnotations.Schema;
namespace TalentoTrack.Common.Entities
{
    public class LoginDetails
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Passward { get; set; }
        public bool IsBlocked { get; set; }

        [ForeignKey("UserId")]
        public TelentoTrack.Common.Entities.User? User { get; set; }

    }
}

