
using EventHub.Models;

namespace EventHub.Services;
public interface IEventService
{
  List<Event> GetAllEvents();
}