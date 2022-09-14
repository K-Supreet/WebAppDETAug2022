using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Microsoft.Extensions.DependencyInjection;
using ToDoApi.Data;
using Microsoft.AspNetCore.OData;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ToDoApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoApiContext") ?? throw new InvalidOperationException("Connection string 'ToDoApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers().AddOData(options => options.Select().Filter());
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseDefaultFiles();
app.UseStaticFiles();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
