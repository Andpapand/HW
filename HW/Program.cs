namespace HW
{
    /*HW 1

    /Д.З. Створити новий проєкт ASP.NET Core MVC 
     * * Додати до нього нові сторінки: 
     * * - Intro з описом ASP
     * * - Razor поки що порожню 
     * * - History з основними етапами історії ASP 
     * * Включити посилання на ці сторінки до заголовкової частити шаблона, 
     * * зробити скріншоти роботи сторінок. 
     * * Опублікувати репозиторій з проєктом, додати до нього директорію * з скріншотами. 
     * * Звіт з ДЗ - посилання на репозиторій */

    /*HW 2

    Д.З.
    Реалізувати відображення товарів з моделі у вигляді HTML-таблиці
    | Назва | Ціна |
    |-------|------|
    | Asus | 18900 | ...
    * використовуючи класи Bootstrap стилізувати таблицю
     https://getbootstrap.com/docs/5.3/content/tables/   */


    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

