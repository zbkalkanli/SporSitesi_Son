using g181210044_g191210044.Entity;
using Microsoft.AspNetCore.Mvc;

namespace g181210044_g191210044.ViewComponents
{
    public class YeniYorumlar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var yorumListesi = new List<Yorum>
            {
                new Yorum
                {
                    Id=1,
                    Icerik="çok faydalı bir yazı",
                    BlogId=1,
                    UyeId=3

                },
                new Yorum {
                    Id=2,
                    Icerik="Denemeyi dusunuyorum.",
                    BlogId=2,
                    UyeId=4
                }
            };
            return View(yorumListesi);
        }
    }
}
