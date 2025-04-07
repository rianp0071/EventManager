public class Attendee
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public DateTime RegistrationDate { get; set; } = DateTime.Now;

    public int EventId { get; set; }
    public Event? Event { get; set; }
}