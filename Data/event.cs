public class Event
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public DateTime DateTime { get; set; }

    public required string Location { get; set; }

    public List<Attendee> Attendees { get; set; } = new List<Attendee>();
}