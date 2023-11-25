using Assignments.DataAccess.Data;
using Assignments.DataAccess.Repository.IRepository;
using Assignments.Models;
using Assignments.Models.ViewModels;
using Assignments.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace TriniCarsDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class VehicleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public VehicleController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Vehicle> objVehicleList = _unitOfWork.Vehicle.GetAll(includeProperties:"Category").ToList();
            
            return View(objVehicleList);
        }
        public IActionResult Upsert(int? id)
        {
            VehicleVM vehicleVM = new()
            {
                CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Vehicle = new Vehicle()
            };
            if (id == null || id == 0)
            {
                //create
                return View(vehicleVM);
            }
            else
            {
                //update
                vehicleVM.Vehicle = _unitOfWork.Vehicle.Get(u => u.Id == id);
                return View(vehicleVM);
            }
            
        }
        [HttpPost]
        public IActionResult Upsert(VehicleVM vehicleVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if(file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string vehiclePath = Path.Combine(wwwRootPath, @"images\vehicle");
                
                    if(!string.IsNullOrEmpty(vehicleVM.Vehicle.ImageUrl))
                    {
                        //delete old image
                        var oldImagePath = Path.Combine(wwwRootPath, vehicleVM.Vehicle.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using( var fileStream = new FileStream(Path.Combine(vehiclePath, fileName),FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    vehicleVM.Vehicle.ImageUrl = @"\images\vehicle\" + fileName;
                }

                if (vehicleVM.Vehicle.Id == 0)
                {
                    _unitOfWork.Vehicle.Add(vehicleVM.Vehicle);
                }
                else
                {
                    _unitOfWork.Vehicle.Update(vehicleVM.Vehicle);
                }
                _unitOfWork.Save();
                TempData["success"] = "Vehicle created successfully";
                return RedirectToAction("Index");
            }
            else
            {
                vehicleVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(vehicleVM);
            }

            
        }
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Vehicle vehicleFromDb = _unitOfWork.Vehicle.Get(u => u.Id == id);
        //    if (vehicleFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(vehicleFromDb);
        //}
        [HttpPost]
        public IActionResult Edit(Vehicle obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Vehicle.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Vehicle updated successfully";
                return RedirectToAction("Index");
            }

            return View();
        }
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Vehicle? vehicleFromDb = _unitOfWork.Vehicle.Get(u => u.Id == id);

        //    if (vehicleFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(vehicleFromDb);
        //}
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePost(int? id)
        //{
        //    Vehicle? obj = _unitOfWork.Vehicle.Get(u => u.Id == id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    _unitOfWork.Vehicle.Remove(obj);
        //    _unitOfWork.Save();
        //    TempData["success"] = "Vehicle deleted successfully";
        //    return RedirectToAction("Index");
        //}

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Vehicle> objVehicleList = _unitOfWork.Vehicle.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = objVehicleList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var vehicleToBeDeleted = _unitOfWork.Vehicle.Get(u => u.Id ==id);
            if(vehicleToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, 
                vehicleToBeDeleted.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }
            _unitOfWork.Vehicle.Remove(vehicleToBeDeleted);
            _unitOfWork.Save();

            //List<Vehicle> objVehicleList = _unitOfWork.Vehicle.GetAll(includeProperties: "Category").ToList();
            return Json(new { success = true, message = "Delete Successful" });
        }
    
        #endregion

    }
}
