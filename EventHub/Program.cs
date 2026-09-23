var builder = WebApplication.CreateBuilder(args);

var events = new List<Event>
{
    new(1, "Tech Meetup", "Bangalore", new DateTime(2026, 7, 15)),
    new(2, "AI Workshop", "Hardboard", new DateTime(2026,8, 25)),
    new(3, "Cloud Conference", "Mumbai", new DateTime(2026, 9, 10))
};

builder.Services.AddOpenApi();

var app = builder.Build();

//Middleware
app.Use(async(context, next) =>
{
    Console.WriteLine($"Incoming request: {context.Request.Method} {context.Request.Path}");

    await next();

    Console.WriteLine($"Response sent: {context.Response.StatusCode}");
});

app.MapGet("/events", ()=> events);


// app.UseHttpsRedirection();

app.Run();
record Event(int Id, string Name, string Location, DateTime Date );




