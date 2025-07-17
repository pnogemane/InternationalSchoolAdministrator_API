using Microsoft.AspNetCore.Mvc;
using InternationalSchoolAdministrator_API.Models;

namespace InternationalSchoolAdministrator_API.Controllers
{
    public class ParentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStudentsProfile(string parentid)
        {
            StudentModel studentModel = new StudentModel();

            studentModel.GetStudentByParentID(parentid);

            return View(studentModel);
        }
    }
}
