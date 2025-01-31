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

builder.Services.AddScoped(typeof(IAudienceDal), typeof(AudienceDal));
builder.Services.AddScoped(typeof(IAudienceBll), typeof(AudienceBll));

builder.Services.AddScoped(typeof(IGameDal), typeof(GameDal));
builder.Services.AddScoped(typeof(IGameBll), typeof(GameBll));

builder.Services.AddScoped(typeof(IGenderDal), typeof(GenderDal));
builder.Services.AddScoped(typeof(IGenderBll), typeof(GenderBll));

builder.Services.AddScoped(typeof(IHowKnownDal), typeof(HowKnownDal));
builder.Services.AddScoped(typeof(IHowKnownBll), typeof(HowKnownBll));

builder.Services.AddScoped(typeof(ISettingDal), typeof(SettingDal));
builder.Services.AddScoped(typeof(ISettingsBll), typeof(SettingsBll));

builder.Services.AddScoped(typeof(ITypeGameDal), typeof(TypeGameDal));
builder.Services.AddScoped(typeof(ITypeGameBll), typeof(TypeGameBll));

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
