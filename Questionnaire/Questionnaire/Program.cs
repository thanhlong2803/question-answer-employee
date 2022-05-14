using be.Services;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//register configuration 
ConfigurationManager configuration = new ConfigurationManager();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add setting connection database
builder.Services.AddDbContext<SettingDbcontext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MainConnection"),
    be => be.MigrationsAssembly("Fail API connection for question")));

//add serviecs to the container
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IQuestionService, QuesitionService>();
builder.Services.AddScoped<IOpitionService, OpitionService>();
builder.Services.AddScoped<ITestService, TestService>();

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
