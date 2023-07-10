using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using VotingPoll.Infrastructure.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLogging(builder =>
{
    builder.AddConsole();
    builder.AddDebug();
});

builder.Services.AddDbContext<PollContext>(options =>
    {
        options.UseInMemoryDatabase("Polls");
        options.EnableSensitiveDataLogging();
    }
);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<PollContext>();

    // Apply migrations or ensure the database is created
    dbContext.Database.EnsureCreated(); // or dbContext.Database.Migrate()

    // Seed the data
    dbContext.SaveChanges();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
