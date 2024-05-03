namespace Domain.Enties.TimeSheets
{
  using Domain.Account;
  using Domain.Entities;

  public class TeamMember : BaseEntity<int>
  {
    public string UserId { get; set; } // Foreign key property
    public int TeamId { get; set; } // Foreign key property

    // Navigation properties if needed
    public virtual ApplicationUser User { get; set; }
    public virtual Team Team { get; set; }
  }
}