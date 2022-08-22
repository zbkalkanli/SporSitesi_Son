using System.ComponentModel.DataAnnotations;

namespace g181210044_g191210044.Entity
{
    public class BlogYazari:Uye
    {
        public virtual List<BlogYazisi> Yazilari { get; set; }

    }
}
