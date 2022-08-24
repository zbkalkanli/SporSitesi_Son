using System.ComponentModel.DataAnnotations;

namespace g181210044_g191210044.Entity
{
    public class BlogYazisi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BegeniSayisi { get; set; }
        public DateTime YayinTarihi { get; set; }
        public string Icerik { get; set; }
        [Required]
        [MinLength(1500)]
        [MaxLength(7500)]
        public string Baslik { get; set; }
        [Required]
        [MaxLength(500)]

        //public int YazarId { get; set; }
        //public virtual BlogYazari BlogYazari { get; set; }
        public virtual List<Yorum> Yorumlar { get; set; }

    }
}
