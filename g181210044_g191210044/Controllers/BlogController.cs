using g181210044_g191210044.Entity;
using g181210044_g191210044.Models;
using Microsoft.AspNetCore.Mvc;


namespace g181210044_g191210044.Controllers
{
    public class BlogController:Controller
    {
        public IActionResult Yayin()
        {
            var blogYazilari = new List<BlogYazisi>()
            {
                new BlogYazisi(){Id=1, BegeniSayisi=3, YayinTarihi=new DateTime(2021,05,11), Icerik="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",Baslik="Yayin",YazarId=1},
                new BlogYazisi(){Id=2, BegeniSayisi=3, YayinTarihi=new DateTime(2021,05,11), Icerik="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",Baslik="Yayin1",YazarId=1},
                new BlogYazisi(){Id=3, BegeniSayisi=3, YayinTarihi=new DateTime(2021,05,11), Icerik="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",Baslik="Yayin2",YazarId=1},
                new BlogYazisi(){Id=4, BegeniSayisi=3, YayinTarihi=new DateTime(2021,05,11), Icerik="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",Baslik="Yayin3",YazarId=1}
            };
            return View(blogYazilari);
        }
    }
}
