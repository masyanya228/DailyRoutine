using Microsoft.AspNetCore.Mvc;

namespace DailyRoutine.Controllers
{
    /// <summary>
    /// Учет рутин
    /// </summary>
    public class RemindController : Controller
    {
        /// <summary>
        /// Дела на сегодня
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Выполнить рутину
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        public IActionResult Complete(Guid tagId)
        {
            return View();
        }
    }
}
