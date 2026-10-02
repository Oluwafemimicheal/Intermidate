using EventHub.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IEventService, EventService>();
builder.Services.AddControllers();


var app = builder.Build();

//Middleware
app.Use(async(context, next) =>
{
    Console.WriteLine($"Incoming request: {context.Request.Method} {context.Request.Path}");

    await next();

    Console.WriteLine($"Response sent: {context.Response.StatusCode}");
});

app.MapControllers();
app.MapGet("/events", (EventService eventService) => eventService.GetAllEvents());

app.Run();





