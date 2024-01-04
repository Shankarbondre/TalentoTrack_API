using Microsoft.EntityFrameworkCore;
using TalentoTrackCommon.Services;
using TalentoTrackDao.Repositories;
using TalentoTrackService;
using TelentoTrack.Dao.DB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddTransient<IAccountRepository, AccountRepository>();

builder.Services.AddDbContext<TelentoTrack_DbContext>(options =>
    options.UseSqlServer(builder.Configuration["ConnectionStrings:TelentoTrackConnection"]));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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