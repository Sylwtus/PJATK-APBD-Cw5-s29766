using Microsoft.EntityFrameworkCore;
using PJATK_APBD_Cw5_s29766.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddDbContext<HospitalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI(o => o.SwaggerEndpoint("/openapi/v1.json","Zadanie5"));
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
