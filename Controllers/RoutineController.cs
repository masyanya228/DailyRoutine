using Microsoft.AspNetCore.Mvc;

namespace DailyRoutine.Controllers
{
    public class RoutineController : Controller
    {
        /// <summary>
        /// Список рутин
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Рутина
        /// </summary>
        /// <param name="routineId"></param>
        /// <returns></returns>
        public IActionResult Page(Guid routineId)
        {
            return View();
        }

        /// <summary>
        /// Изменить рутину
        /// </summary>
        /// <param name="routineId"></param>
        /// <returns></returns>
        public IActionResult Edit(Guid routineId)
        {
            return View();
        }
    }
}
