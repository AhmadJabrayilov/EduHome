using homeeduTest.DAL;
using homeeduTest.Models;
using homeeduTest.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace homeeduTest
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.sliders = _context.Sliders.ToList();
            homeVM.pageIntro = _context.PageIntros.FirstOrDefault();
            homeVM.noticeBoards = _context.NoticeBoards.ToList();
            homeVM.courseDetails = _context.CourseDetails.ToList();
            homeVM.courseCards = _context.CourseCards.ToList();

            return View(homeVM);  
        }
    }
}
