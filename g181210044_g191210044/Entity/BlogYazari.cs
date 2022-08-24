using System.ComponentModel.DataAnnotations;

namespace g181210044_g191210044.Entity
{
    public class BlogYazari
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime KatilimTarihi { get; set; }
        public string MailAdresi { get; set; }
        [Required]
        [MaxLength(50)]
        public string Ad { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Soyad { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Sifre { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public virtual List<Yorum> YaptigiYorumlar { get; set; }
        public virtual List<BlogYazisi> Yazilari { get; set; }

    }
}
