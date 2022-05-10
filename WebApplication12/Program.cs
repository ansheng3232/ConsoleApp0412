var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//master
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//12132
app.UseHttpsRedirection();
app.UseHttpsRedirection();
app.UseHttpsRedirection();
app.UseHttpsRedirection();
//12
app.UseAuthorization();
//12
app.MapControllers();
//12456
//1234562
app.Run();
app.Run();
//123
