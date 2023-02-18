// using AccountManager.Services;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using AccountManager.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("MariaDbConnectionString");
builder.Services.AddDbContext<DatabaseContext>(options => options.UseMySql(
    connectionString,
    ServerVersion.AutoDetect(connectionString)
));
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
}

app.UseAuthorization();
app.UseStaticFiles();
app.UseDefaultFiles();
app.UseRouting();

app.MapControllers();
app.MapRazorPages();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
