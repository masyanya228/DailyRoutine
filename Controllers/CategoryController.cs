using Microsoft.AspNetCore.Mvc;

namespace DailyRoutine.Controllers
{
    public class CategoryController : Controller
    {
        /// <summary>
        /// Список категорий
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Категория
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public IActionResult Page(Guid categoryId)
        {
            return View();
        }

        /// <summary>
        /// Изменить категорию
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public IActionResult Edit(Guid categoryId)
        {
            return View();
        }

        /// <summary>
        /// Вернуть список категорий для выбора
        /// </summary>
        /// <returns></returns>
        public IActionResult GetList()
        {
            return Json(null);
        }
    }
}
