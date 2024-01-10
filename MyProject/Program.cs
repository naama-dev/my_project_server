using Microsoft.EntityFrameworkCore;
using Models.Models;
using DAL.Data;
using DAL.Interface;

var builder = WebApplication.CreateBuilder(args);
string myCors = "_myCors";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(op =>
{
    op.AddPolicy(myCors,
        builder =>
        {
            builder.WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});
builder.Services.AddScoped<IUser,UserData>();
builder.Services.AddScoped<IPost,PostData>();
builder.Services.AddScoped<IPhoto, PhotoData>();
builder.Services.AddScoped<IToDo, ToDoData>();
builder.Services.AddDbContext<DataProjectContext>(item => item.UseSqlServer("DefaultDataBase"));
var app = builder.Build();

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
