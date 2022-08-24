using System.ComponentModel.DataAnnotations;

namespace g181210044_g191210044.Entity
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Icerik { get; set; }
        [Required]
        [MinLength(50)]
        [MaxLength(3000)]
        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }
        public int? BlogId { get; set; }
        public virtual BlogYazisi BlogYazisi { get; set; }

    }
}
