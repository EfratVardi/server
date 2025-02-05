using BLL.Functions;
using BLL.Interfaces;
using DAL.Functions;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CountdContext>(options => options.UseSqlServer("Server=.;Database=countd;TrustServerCertificate=True;Trusted_Connection=True;"));

builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddScoped(typeof(IUserDal), typeof(UserDal));
builder.Services.AddScoped(typeof(IUserBll), typeof(UserBll));

builder.Services.AddScoped(typeof(IUserDetailDal), typeof(UserDetailDal));
builder.Services.AddScoped(typeof(IUserDetailsBll), typeof(UserDetailsBll));


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod();
    ;
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
