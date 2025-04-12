public class Event
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public DateTime DateTime { get; set; }

    public required string Location { get; set; }

    public Dictionary<int, Attendee> Attendees { get; set; } = new Dictionary<int, Attendee>();

}