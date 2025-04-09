using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext with SQL Server connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add controllers for API endpoints
builder.Services.AddControllers();

// Add Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS policy to allow React app (running on localhost:3000) to access the backend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy => policy.WithOrigins("http://localhost:3000") // React app's URL
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

// Use CORS policy before routing
app.UseCors("AllowReactApp");

// Enable Swagger middleware
app.UseSwagger();
app.UseSwaggerUI();

// Enable HTTPS redirection and authorization
app.UseHttpsRedirection();
app.UseAuthorization();

// Use routing and map API controllers
app.UseRouting();
app.MapControllers();

// Optional: Serve static files if needed (uncomment if required)
// app.UseStaticFiles();

app.Run("http://localhost:5000"); // Run the application on port 5000
