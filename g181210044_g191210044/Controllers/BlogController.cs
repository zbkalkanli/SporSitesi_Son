using g181210044_g191210044.Data;
using g181210044_g191210044.Entity;
using g181210044_g191210044.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace g181210044_g191210044.Controllers
{
    public class BlogController : Controller
    {

        public IActionResult Index()
        {
            var model = new BlogPageViewModel
            {
                BlogYazilari = BlogYazisiRepository.BlogYazisis
            };

            return View(model);
        }
        public IActionResult Index2()
        {
            var model = new CommentViewModel
            {
                Yorumlar = YorumRepository.Yorums
            };

            return View(model);
        }

    }
}
