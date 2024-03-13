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
