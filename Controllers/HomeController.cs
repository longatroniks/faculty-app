using LonginKP3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LonginKP3.Controllers
{
    /// <summary>
    /// The HomeController extends the Controller class,
    /// and it is used to access data from the model which
    /// is then displayed inside of the view. This is done
    /// with the help of asynchronous options.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Helps with debugging by keeping track of errors
        /// that occured within the program's lifespan.
        /// </summary>
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Constructor that sets it's logger to the one
        /// inserted inside of the parameter.
        /// </summary>
        /// <param name="logger">ILogger</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// This method creates a View() object, and
        /// sets its model by accepting it through the
        /// parameters.
        /// 
        /// This method is specific for the Index page 
        /// which holds the data from the about api. 
        /// </summary>
        /// <returns>View()</returns>
        public async Task<IActionResult> Index()
        {
            var data = await IndexModel.GetAsync();
            return View(data);
        }

        /// <summary>
        /// This method creates a View() object, and
        /// sets its model by accepting it through the
        /// parameters.
        /// 
        /// This method is specific for the Degrees page 
        /// which holds the data from the degrees api. 
        /// </summary>
        /// <returns>View()</returns>
        public async Task<IActionResult> Degrees()
        {
            var data = await DegreesModel.GetAsync();
            return View(data);
        }

        /// <summary>
        /// This method creates a View() object, and
        /// sets its model by accepting it through the
        /// parameters.
        /// 
        /// This method is specific for the Employment page 
        /// which holds the data from the employment api. 
        /// </summary>
        /// <returns>View()</returns>
        public async Task<IActionResult> Employment()
        {
            var data = await EmploymentModel.GetAsync();
            return View(data);
        }

        /// <summary>
        /// This method creates a View() object, and
        /// sets its model by accepting it through the
        /// parameters.
        /// 
        /// This method is specific for the Faculty page 
        /// which holds the data from the faculty api. 
        /// </summary>
        /// <returns>View()</returns>
        public async Task<IActionResult> Faculty()
        {
            var data = await FacultyModel.GetAsync();
            return View(data);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}