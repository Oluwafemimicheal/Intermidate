using EventHub.Models;

namespace EventHub.Services;
public class EventService
{
  private readonly List<Event> _events = new List<Event>
  {
     new(1, "Tech Meetup", "Bangalore", new DateTime(2026, 7, 15)),
    new(2, "AI Workshop", "Hardboard", new DateTime(2026,8, 25)),
    new(3, "Cloud Conference", "Mumbai", new DateTime(2026, 9, 10))
  };

  public List<Event> GetAllEvents()
  {
    return _events;
  }
}