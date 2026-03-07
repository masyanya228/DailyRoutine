using Microsoft.AspNetCore.Mvc;

namespace DailyRoutine.Controllers
{
    /// <summary>
    /// История выполнения рутин
    /// </summary>
    public class HistoryController : Controller
    {
        /// <summary>
        /// Выполнено вчера
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return Watch(DateTime.Now.AddDays(-1));
        }

        /// <summary>
        /// Просмотреть историю
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        public IActionResult Watch(
            DateTime start,
            DateTime end = default,
            int days = default,
            Guid routineId = default,
            Guid categoryId = default,
            Guid tagId = default)
        {
            return View();
        }
    }
}
