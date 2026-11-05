using Microsoft.AspNetCore.Mvc;
using MyBusinessCard.Models;

namespace MyBusinessCard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var myInfo = new Person
            {
                FullName = "Иванов Иван Иванович",
                BirthDate = new DateTime(2000, 5, 15),
                Description = "Начинающий .NET разработчик. Увлекаюсь созданием веб-приложений и изучением архитектурных паттернов. Люблю решать сложные логические задачи."
            };

            return View(myInfo);
        }
    }
}
