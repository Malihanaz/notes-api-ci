var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var notes = new List<string>();

app.MapGet("/", () => "Notes API Running");

// Get all notes
app.MapGet("/notes", () => notes);

// Add note
app.MapPost("/notes", (string note) =>
{
    notes.Add(note);
    return Results.Ok("Note added");
});

app.Run();
