# AspNetCore.DesignPrinciples

<h2>Design Principles</h2>

<h3>1- Single Responsibility (Tek Sorumluluk)</h3>

<p>Single responsibility prensibi sınıflarımızın iyi tanımlanmış tek bir sorumluluğu olması gerektiğini anlatmaktadır. Bir sınıf (nesne) yalnızca bir amaç uğruna değiştirilebilir, o amaçta o sınıfa yüklenen sorumluluktur, yani bir sınıfın yapması gereken yalnızca bir işi olması gerekir.
</p>
<p>
Eğer geliştirdiğiniz sınıf ya da fonksiyon birden fazla amaca hizmet ediyorsa, bu kurala aykırı bir geliştirme sürecinde olduğunuz anlamına geliyor. Bunu farkettiğinizde amaçlara uygun olarak parçalamanız gerekmektedir.
</p>

<p>
Gereksinimler değiştiğinde, yazılan kodda da değişmesi gereken kısımlar olacaktır. Bu da yazılan sınıfların(nesnelerin) bir kısmının ya da tamamının değiştirilmesi anlamına gelir. Bir sınıf ne kadar fazla sorumluluk alırsa, o kadar fazla değişime uğramak zorunda kalır. Böylece birçok kod parçasının değişmesine neden olurken, yeniden yazımda; değişikliklerin uygulanması da bir o kadar zorlaşır.
</p>

<p>
Bir sınıfı veya fonksiyonu geliştirdiğimizde sorumluluğunu ya da amacını iyi belirleyip, sınıfı ona göre tasarlamamız gerekir, böylece oluşabilecek herhangi bir değişimden, olabildiğince az şeyi güncelleyerek ve düzelterek istenilen geliştirmeyi gerçekleştirmiş oluruz. Sorumluluğun azaltılması demek değişime daha kolay adapte olmak demektir.
</p>

<h3>2- Open/Closed (Açık/Kapalı)</h3>

<p>
Sınıflarımız/fonksiyonlarımız değişikliğe kapalı ancak yeni davranışların eklenmesine açık olmalıdır.
</p>

<p>
Open Sınıf için yeni davranışlar eklenebilmesini sağlar. Gereksinimler değiştiğinde, yeni gereksinimlerin karşılanabilmesi için bir sınıfa yeni veya farklı davranışlar eklenebilir olmasıdır.
Closed Bir sınıf temel özelliklerinin değişimi ise mümkün olmamalıdır.
</p>

<p>
Geliştirdiğimiz yazılıma/sınıfa varolan kodu değiştirmeden, yeni kod yazılarak yeni özellikler eklenebilmelidir. Yeni bir gereksinim geldiğinde mevcut kod üzerinde herhangi bir değişiklik yapıyorsanız, open/closed prensibine ters düşüp düşmediğinizi kontrol etmenizde yarar var. Yazılımı geliştirirken gelecekte oluşabilecek özellikler ve geliştirmeleri her şeyiyle öngöremeyiz. O yüzden oluşabileceğini düşündüğümüz kodlarıda şimdiden geliştirmemeliyiz. (bknz: KISS) Yeni gelecek özellikler için varolan kodu değiştirmeden, varolan yapıyı bozmadan esnek bir geliştirme modeli uygulayarak, önü açık ve gelecekten gereksinimlere kolayca adapte olup, ayak uydurabilen bir model uygulamalıyız.
</p>

<h3>3- Liskov Substitution (Liskov Yerine Geçme Prensibi)</h3>

<p>
Türeyen sınıf yani alt sınıflar ana(üst) sınıfın tüm özelliklerini ve metotlarını aynı işlevi gösterecek şekilde kullanabilme ve kendine ait yeni özellikler barındırabilmelidir.
</p>

<p>
Alt seviye sınıflardan oluşan nesnelerin/sınıfların, ana(üst) sınıfın nesneleri ile yer değiştirdikleri zaman, aynı davranışı sergilemesi gerekmektedir. Türetilen sınıflar, türeyen sınıfların tüm özelliklerini kullanabilmelidir.
</p>

<h3>4- Interface Segregation (Arayüz Ayrım Prensibi)</h3>

<p>
Tek bir interface yerine kullanımlarına göre parçalanmış birden fazla interface ile işlemleri yürütmeliyiz. Yani her farklı sorumluluğun kendine özgü bir arayüzü olması gerekmektedir. Böylece interface’i kullanan kişide sadece ihtiyacı olanlarla ilgilenmiş olur. Birden fazla amaç için yalnızca bir arayüzümüz var ise buna gerektiğinden fazla method ya da özellik ekliyoruz demektir, bu da IS prensibine aykırı davrandığınız anlamına gelir..
</p>

<p>
Nesneler asla ihtiyacı olmayan property/metot vs içeren interfaceleri implement etmeye zorlanmamalıdır
</p>

<p>
Görüldüğü gibi single responsibility ve interface segregation prensipleri birbirine oldukça yakın ve aynı amaca hizmet eden prensiplerdir. Tek fark ise Interface segregation arayüz(interface)ler ile ilgilenirken, Single responsibility sınıflarla ilgilenmektedir.
</p>

<p>
Bir methodun IS prensibine uymayan interface’e eklenmesi veya bir method üzerindeki değişiklik, Bu interface’i kullanan(implement etmiş) tüm sınıfları değiştirmemizi gerektirir. Bir arayüz yazarken, farklı sorumlulukları ya da farklı davranış gruplarını her zaman farklı arayüzlere ayırmak önemlidir.
</p>

<h3>5- Dependency Inversion (Bağımlılıkları Tersine Çevirme)</h3>

<p>
Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.
</p>

<p>
Bir sınıfın, metodun ya da özelliğin, onu kullanan diğer sınıflara karşı olan bağımlılığı en aza indirgenmelidir. Bir alt sınıfta yapılan değişiklikler üst sınıfları etkilememelidir.
</p>

<p>
Yüksek seviye sınıflarda bir davranış değiştiğinde, alt seviye davranışların bu değişime uyum sağlaması gerekir. Ancak, düşük seviye sınıflarda bir davranış değiştiğinde, üst seviye sınıfların davranışında bir bozulma meydana gelmemelidir.
</p>

<p>
Peki, bütün bu sorunlardan kurtulmanın yolu nedir ?
Cevap: Dependency Inversion, yani üst sınıflar, alt seviyeli sınıflara bağlı olmamalı, çözüm ise her ikisi de soyut kavramlar üzerinden yönetilebilmelidir. Yüksek seviye ve düşük seviye sınıflar arasında bir soyutlama katmanı oluşturabiliriz.
</p>

<p>
<b>Üst Seviye Sınıflar -> Soyutlama Katmanı -> Düşük Seviye Sınıfları</b>
</p>
