using EliaGroup.API.Configurations;
using EliaGroup.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connString = builder.Configuration.GetConnectionString("EliaConnection");
builder.Services.AddDbContext<EliaDbContext>(options => options.UseSqlServer(connString)    );

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//should be updated with the address of localhost or server
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", b => b.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
});
builder.Services.AddAutoMapper(typeof(MapperConfig));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

