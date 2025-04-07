namespace EventManagerApp.Services
{
    public interface IEventService
    {
        void AddEvent(Event eventItem);
        List<Event> GetAllEvents();
        int GetNextId();
        void ClearEvents();
        Task<List<Event>> GetEventsAsync();
        Task<Event?> GetEventByIdAsync(int eventId);

        void AddAttendee(int eventId, Attendee attendee);
        Task<List<Attendee>> GetAttendeesAsync(int eventId);
        int GetNextAttendeeId(int eventId);
    }
}