using Microsoft.EntityFrameworkCore;
using StudentCrud.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDbContext")));


var app = builder.Build();
app.UseCors(policy => policy.AllowAnyHeader()
.AllowAnyMethod().SetIsOriginAllowed(origin => true).AllowCredentials());
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
