using EventHub.Services;
using Microsoft.AspNetCore.Mvc;
namespace EventHub.EventControllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
  private readonly IEventService? _eventService;

  public EventsController(IEventService eventService)
  {
    _eventService = eventService;
  }

  [HttpGet]
  public IActionResult GetAll()
  {
    return Ok(_eventService?.GetAllEvents());
  }

  [HttpGet("{id}")]
  public IActionResult GetById(int id)
  {
    var foundEvent = _eventService?.GetAllEvents().FirstOrDefault(e => e.Id == id);

    if (foundEvent == null)
    {
      return NotFound();
    }

    return Ok(foundEvent);
  }
  
}