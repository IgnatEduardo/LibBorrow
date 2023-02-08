using Microsoft.EntityFrameworkCore;
using proiectDaw.Data;
using proiectDaw.Helper;
using proiectDaw.Helper.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//db
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//services
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddJwtUtils();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

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
