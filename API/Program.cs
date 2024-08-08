using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region App Services
builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(opt =>
{
  opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
#endregion

var app = builder.Build();

#region App Middlewares
app.MapControllers();
#endregion

app.Run();
