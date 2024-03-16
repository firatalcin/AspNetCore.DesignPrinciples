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
