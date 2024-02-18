using WebApplication2.entities;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// task 1
Company companyApple = new("Apple", 15000);

app.MapGet("/task1", () => companyApple.Name + " , employees: " + companyApple.Employees);

// task 2
int randValue = new Random().Next(101);
app.MapGet("/task2", () => randValue);

app.Run();
