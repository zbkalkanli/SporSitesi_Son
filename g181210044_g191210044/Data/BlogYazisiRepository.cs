﻿using g181210044_g191210044.Entity;

namespace g181210044_g191210044.Data
{
    public class BlogYazisiRepository
    {
        private static readonly List<BlogYazisi> _blogYazilari = null;
        static BlogYazisiRepository()
        {
            _blogYazilari = new List<BlogYazisi>()
            {
                new BlogYazisi {Id=1, BegeniSayisi=0, YayinTarihi = new DateTime(12,01,2020), Icerik="Bu sabah alışkanlıklarını rutin haline getirerek günün tamamını çok daha iyi geçirebilirsin!\r\nSağlam bir sabah rutini tüm günün gidişatını belirler. Bazı sabah alışkanlıkları geliştirmek günün geri kalanında da zihinsel ve fiziksel sağlığına öncelik vermeni kolaylaştırabilir. Herkesin ideal sabah rutini farklı olacaktır, ancak burada önemli olan nokta bir tutarlılık oluşturmaktır. Bunun faydası sabah yaptığın işlerin sabit bir sırası olacağından, beynini sürekli “Şimdi sırada ne var?” sorusunu cevaplamaktan kurtarmasıdır.\r\n\r\nİşte sabah rutinine eklemen ve günün tamamını çok daha iyi geçirebilmen için altı öneri!\r\n\r\n1. Yatağını Düzelt Yatağı toplamak sabah uyanır uyanmaz yapmak istemeyeceğin bir iş olabilir ancak kendini iyi hissetmen için son derecede basit ve küçük bir yöntemdir. Bu, hem evini ve zihnini daha az dağınık hale getirmek için önemlidir hem de bu iyi hissin ardında bir de psikolojik neden yatar. Yatağını her sabah topladığında günün ilk görevini tamamlamış olursun. Bu da sana küçük de bir gurur hissi verir ve seni sonraki görev yapmaya teşvik eder.\r\n\r\n2. Telefonunu Kontrol Etmeyi Bırak\r\n\r\nTelefonlarımızı her kontrol ettiğimizde, özellikle de bunu uzun bir uyku arasından sonra yaptığımızda, beynimize bir uyarı seli davet ediyoruz. Haberler, mesajlar ve dikkatini çekmek isteyen bildirimler birçok potansiyel stres etkenini barındırıyor. Neden bunu biraz geciktirmiyorsun? Uyandığın andaki genel sakinlik seviyesini elinden geldiğince uzun süre korumak harika olmaz mıydı? Ayrıca uyanır uyanmaz ilk iş telefona bakmak, muhtemelen sosyal medya akışlarında kaybolacağın için sana zaman kaybettirip tüm sabah rutinini de raydan çıkarır.\r\n\r\n3. Esneme Hareketleri Yap\r\n\r\nSabah egzersiz yapma alışkanlığı olan biri olmasan bile sabahları iyi bir esnemenin tadını çıkarabilirsin. Bu uzun bir rutin olmak zorunda değil, sadece kan dolaşımını hızlandırması ve birkaç esneme hareketinin verdiği iyi hislerden faydalanmanı sağlaması yeterli.\r\n\r\n4. Su İç Gün boyunca vücuduna yeterli su alman gerektiğini biliyorsun, ancak yaklaşık sekiz saat su içmemiş olduğun için sabahları içeceğin bir bardak su belki de hepsinden önemli. Sabah ilk bardak suyunu uyanır uyanmaz içmeyi alışkanlık haline getirmek çok işine yarayabilir. Hatta başucuna geceden bir bardak su koyarak uyandığında hemen su içmeyi garantileyebilirsin.\r\n\r\n5. Eğlenceli veya Yaratıcı Bir Şeyler Yap “Rutin” kavramı kulağa görev üzerine görev tamamladığın bir süreç gibi gelebilir. Ama aslında sabah rutinine seni eğlendirip rahatlatan şeyler de eklemelisin. Örneğin kahveni içerken telefonda sevdiğin bir oyunu oynamak gibi… Eğlenceli bir şeye zaman ayırmak, sabahı günün işe başlamadan önceki bölümü olarak değil, başlı başına bir bölüm olarak düşünmeye yardımcı olur. Bu da uyanmayı kolaylaştırır, çünkü alarmın çaldığında az sonra kendine huzurlu ve eğlenceli bir zaman ayıracağını bilirsin. Oyun oynamayı sevmiyorsan, normalde günün farklı saatleri için ayırdığın dizi izlemek, el işi yapmak, hareketli müzik açıp dans etmek, evcil hayvanınla oynamak, kitap okumak gibi aktiviteleri de tercih edebilirsin.\r\n\r\n6. Günlük Yapılacaklar Listeni Yaz veya Gözden Geçir\r\n\r\nsabah alışkanlıkları\r\n\r\nBazı insanlar için ideal bir sabah rutininin içinde işe yer yoktur. Ancak bazıları içinse kaçınılmaz e-postalar veya toplantılarla dikkatleri dağılmadan önce, biraz strateji geliştirmek için iyi bir zamandır. Günlük planını yazmak veya gözden geçirmek için zaman ayırdığında, enerjini ve zamanını nereye odaklayacağını da önceden bilirsin.", Baslik="Gününü daha iyi geçirebilmen için tavsiyeler"}
            };
        }
    }
}