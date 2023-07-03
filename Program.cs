
global using simpleapi.Data;

global using Microsoft.EntityFrameworkCore;

// add Model/HotelBooking namespace 


var builder = WebApplication.CreateBuilder(args);

// below code to test the api crud without real database it use inMemoryDatabase which is for test only
//builder.Services.AddDbContext<ApiContext>(
//  opt => opt.UseInMemoryDatabase("BookingDb"));

builder.Services.AddDbContext<ApiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
 

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();