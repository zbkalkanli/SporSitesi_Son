using g181210044_g191210044.Entity;

namespace g181210044_g191210044.Data
{
    public class AdminRepository
    {
        private static readonly List<Admin> _list = null;
        static AdminRepository()
        {
            _list = new List<Admin>()
            {
                new Admin{Id=1, KatilimTarihi=new DateTime(2010, 5, 20, 12, 20, 45), MailAdresi="abcdef@gmail.com", Ad="Zeynep", Soyad="Kalkanlı", Sifre="abcdefgh22" }
            };
        }
    }
}
