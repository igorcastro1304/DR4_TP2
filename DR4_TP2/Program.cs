namespace DR4_TP2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Pessoa}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "pessoa",
                pattern: "pessoa",
                defaults: new { controller = "Pessoa", action = "Index" });

            app.Run();
        }
    }
}