namespace BookApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add services
            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyCors", builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    ;
                });
            });

            var app = builder.Build();
            app.UseCors("MyCors");

            //map services
            app.MapControllers();
            app.MapGet("/", () =>
            {
                return Results.Redirect("/api/books");
            });

            app.Run();
        }
    }
}
