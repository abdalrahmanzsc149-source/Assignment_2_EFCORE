namespace Assignment_2_EFCORE.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public string CredentialNumber { get; set; } = null!;
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;
    }
}