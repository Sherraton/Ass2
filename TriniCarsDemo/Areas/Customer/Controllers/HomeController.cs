using Assignments.DataAccess.Repository.IRepository;
using Assignments.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TriniCarsDemo.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Vehicle> vehicleList = _unitOfWork.Vehicle.GetAll(includeProperties: "Category");
            return View(vehicleList);
        }

        public IActionResult Details(int vehicleId)
        {
            Vehicle vehicle = _unitOfWork.Vehicle.Get(u=>u.Id== vehicleId, includeProperties: "Category");
            return View(vehicle);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
