using g181210044_g191210044.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace g181210044_g191210044.Data
{
    public class BlogYazariRepository
    {
        public static readonly List<BlogYazari> _blogYazarlari = null;
        static BlogYazariRepository()
        {
            _blogYazarlari = new List<BlogYazari>()
            {
                new BlogYazari{Id=1, KatilimTarihi=new DateTime(2008, 8, 29, 19, 27, 15), MailAdresi="abc@gmail.com", Ad="Esra", Soyad="Yılmaz", Sifre="abcdefgh11"}
            };
        }
    }
}
