namespace EventManagerApp.Services
{
    public class EventService : IEventService
    {
        private Dictionary<int, Event> events;
        private Dictionary<int, int> eventAttendeeCount;
        private int eventCount;

        public EventService()
        {
            events = new Dictionary<int, Event>();
            // Removed unused attendees dictionary initialization
            eventAttendeeCount = new Dictionary<int, int>();
            eventCount = 0;
        }

        public void AddEvent(Event newEvent)
        {
            if (newEvent != null && !events.ContainsKey(newEvent.Id))
            {
                events[newEvent.Id] = newEvent;
                eventCount++;
            }
        }

        public List<Event> GetAllEvents()
        {
            return events.Values.ToList();
        }

        public int GetNextId()
        {
            // If there are no events, return 0 as the next ID
            if (eventCount == 0)
            {
                return 1;
            }
            // Return the next ID based on the count of existing events
            return eventCount + 1;
        }

        public void ClearEvents()
        {
            events = new Dictionary<int, Event>();
            eventAttendeeCount = new Dictionary<int, int>();
            eventCount = 0;
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            // Simulate an asynchronous operation (e.g., fetching from a database)
            await Task.Delay(100); // Simulate some delay
            return events.Values.ToList();
        }

        public async Task<Event?> GetEventByIdAsync(int EventId)
        {
            await Task.Delay(100); // Simulate some delay for async operation
            if (!events.ContainsKey(EventId))
            {
                Console.WriteLine($"Event with ID {EventId} not found.");
                return null;        
            }
            return events[EventId];
        }

        public void deleteEvent(int eventId)
        {
            if (events.ContainsKey(eventId))
            {
            // Remove the event and its associated attendee count
            events.Remove(eventId);
            eventAttendeeCount.Remove(eventId);
            }
        }

        public void AddAttendee(int eventId, Attendee attendee)
        {
            if (attendee != null && events.ContainsKey(eventId))
            {
                if (events[eventId].Attendees == null)
                {
                    // Initialize the Attendees dictionary if it doesn't exist
                    events[eventId].Attendees = new Dictionary<int, Attendee>();
                }

                events[eventId].Attendees[attendee.Id] = attendee;

            }
        }

        public async Task<List<Attendee>> GetAttendeesAsync(int eventId)
        {
            if (!events.ContainsKey(eventId))
            {
                return await Task.FromResult(new List<Attendee>());
            }
            return await Task.FromResult(events[eventId].Attendees.Values.ToList());
        }

        public int GetNextAttendeeId(int eventId)
        {

            // Return the next attendee ID based on the count of existing attendees
            if (!eventAttendeeCount.ContainsKey(eventId))
            {
                eventAttendeeCount[eventId] = 0; // Initialize attendee count if not present
            }
            eventAttendeeCount[eventId]++;
            return eventAttendeeCount[eventId];
        }

        public void DeleteAttendee(int eventId, int attendeeId)
        {
            if (events.ContainsKey(eventId) && events[eventId].Attendees != null && events[eventId].Attendees.ContainsKey(attendeeId))
            {
                events[eventId].Attendees.Remove(attendeeId);
            }
        }

    }
}