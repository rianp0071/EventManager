namespace EventManagerApp.Services
{
    public class EventService : IEventService
    {
        private List<Event> events;

        public EventService()
        {
            events = new List<Event>();
        }

        public void AddEvent(Event newEvent)
        {
            if (newEvent != null)
            {
                events.Add(newEvent);
            }
        }

        public List<Event> GetAllEvents()
        {
            return events;
        }

        public int GetNextId()
        {
            // If there are no events, return 0 as the next ID
            if (events.Count == 0)
            {
                return 1;
            }
            // Return the next ID based on the count of existing events
            return events.Count + 1;
        }

        public void ClearEvents()
        {
            events.Clear();
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            // Simulate an asynchronous operation (e.g., fetching from a database)
            await Task.Delay(100); // Simulate some delay
            return events;
        }

        public async Task<Event?> GetEventByIdAsync(int EventId)
        {
            await Task.Delay(100); // Simulate some delay for async operation
            if (EventId < 1 || EventId > events.Count)
            {
                return null;
            }
            return events[EventId-1]; // Adjusting for 0-based index
        }

        public void AddAttendee(int eventId, Attendee attendee)
        {
            if (attendee != null && eventId > 0 && eventId <= events.Count)
            {
                events[eventId - 1].Attendees.Add(attendee);
            }
        }

        public async Task<List<Attendee>> GetAttendeesAsync(int eventId)
        {
            if (eventId < 1 || eventId > events.Count)
            {
                return await Task.FromResult(new List<Attendee>());
            }
            return await Task.FromResult(events[eventId - 1].Attendees);
        }

        public int GetNextAttendeeId(int eventId)
        {
            if (eventId < 1 || eventId > events.Count)
            {
                return 1; // Default to 1 if the event ID is invalid
            }
            // Return the next attendee ID based on the count of existing attendees
            return events[eventId - 1].Attendees.Count + 1;
        }

    }
}