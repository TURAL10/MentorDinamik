using MentorDinamik.DAL;
using MentorDinamik.ModelViews;
using Microsoft.AspNetCore.Mvc;

namespace MentorDinamik.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            HomeVM vm = new();
            vm.Features = _appDbContext.Features.ToList();
            vm.Courses = _appDbContext.Courses.ToList();
            vm.Trainers = _appDbContext.Trainers.ToList();
            vm.WhyUss = _appDbContext.WhyUss.ToList();
            vm.Abouts = _appDbContext.Abouts.ToList();
            vm.AboutImages = _appDbContext.AboutImages.FirstOrDefault();
            return View(vm);
        }
    }
}
