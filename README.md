# Rest Api Design

### Rest Nedir?
Rest (REpresentational State Transfer), Client–server arasında JSON veya XML türde veriler taşıyarak kolay bir şekilde iletişim kurulmasını sağlayan servis yapısıdır. SOAP ve WSDL tabanlı Web servislerine alternatif olarak geliştirilmiştir. HTTP yöntemlerini ve HTTP durum kodlarını(GET, POST, PUT, DELETE vb) kullanmaktadır. 

### RESTful Nedir?
RESTful, REST mimarisini kullanan web servisleridir.

### HTTP Yöntemleri

* GET : Sunucudan veri getirmek için kullanılır.
* POST : Sunucuya veri eklemek için kullanılır.
* PUT : Sunucudaki bir veriyi güncellemek için kullanılır.
* PATCH : Sunucudaki verinin belirli bir kısmını güncellemek için kullanılır. (JsonPatchDocument)
* DELETE : Sunucudaki bir veriyi silmek için kullanılır.


### HTTP Durum Kodları
* 1xx - Bilgi Mesajları
* 2xx - Başarı Mesajları
* 3xx - Yönlendirme Mesajları
* 4xx - İstemci Hata Mesajları
* 5xx - Sunucu Hata Mesajları

## Richardson Maturity Model
API'nizi REST kısıtlamalarına göre derecelendirmenin bir yoludur. API'niz bu kısıtlamalara ne kadar iyi uyarsa, puanı o kadar yüksek olur. Richardson Olgunluk Modeli, 4 seviyeden oluşur.

### Seviye 0 (Swamp of POX)
Sadece sunucuya istek atma amaçlı sabit bir URI ve genellikle sadece Post Method olarak yapılan istekler içerir. Tüm bilgiler body içerisinde belirtilir (Başarılı, başarısız gibi bilgileri de). Soap web servisleri stiliyle ilerlenir.
* Single URI
* Single HTTP Method

### Seviye 1 (Resources)
Her isteğe özel bir URI belirlenir. HTTP method olarak sadece bir adet tip kullanılır. Genellikle bu tip POST'dur.
* Many URI
* Single HTTP Method

### Seviye 2 (HTTP Verbs)
HTTP yöntemleri ve HTTP durum kodları uygun biçimde kullanılır.
* Many URI
* Multiple HTTP Method

### Seviye 3 (Hypermedia Controls)
Bu seviyede bir rest servisi çağrısı sonucunda dönen sonuca ek olarak, servis sonucu ile etkileşimli ve çağrı yapılabilecek servislerin de dönmesi sağlanır.
HATEOAS (Hypertext As The Engine Of Application State), yöntemi ile dökümantasyona gerek kalmadan her istekde bilgi verilmesi amaçlanmıştır.
* Many URI
* Multiple HTTP Method
* Resource describes own capabilities
* Resource describes own interactions
