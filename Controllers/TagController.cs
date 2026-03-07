using Microsoft.AspNetCore.Mvc;

namespace DailyRoutine.Controllers
{
    public class TagController : Controller
    {
        /// <summary>
        /// Список тэгов
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Тэг
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        public IActionResult Page(Guid tagId)
        {
            return View();
        }

        /// <summary>
        /// Изменить тэг
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        public IActionResult Edit(Guid tagId)
        {
            return View();
        }

        /// <summary>
        /// Вернуть список тэгов для выбора
        /// </summary>
        /// <returns></returns>
        public IActionResult GetList()
        {
            return Json(null);
        }
    }
}
