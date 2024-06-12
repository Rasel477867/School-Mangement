using Microsoft.AspNetCore.Mvc;
using SchoolMS.Service.Contacts;

namespace SchoolMS.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public async Task<IActionResult> Index()
        {
            var model=await _teacherService.GetAll();

            return View(model);
        }
    }
}
