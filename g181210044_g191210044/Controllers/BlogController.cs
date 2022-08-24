using g181210044_g191210044.Data;
using g181210044_g191210044.Entity;
using g181210044_g191210044.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace g181210044_g191210044.Controllers
{
    public class BlogController : Controller
    {

        private readonly SporContext _context;

        public BlogController(SporContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}
