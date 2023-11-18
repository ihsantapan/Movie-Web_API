# Movie-Web_API
--------------------------------------------------------------------------
Film Dünyası API

Film Dünyası API, film, kategori ve oyuncu verileri üzerinde temel CRUD 
(Create, Read, Update, Delete) operasyonlarını gerçekleştirmenizi sağlayan 
bir web servisi sunmaktadır. Bu API, bir film veritabanını yönetmek ve 
film, kategori ve oyuncularla ilgili işlemleri kolayca gerçekleştirmenize 
olanak tanır.

--------------------------------------------------------------------------
--------------------------------------------------------------------------

Film API Dokümantasyonu
--------------------------------------------------------------------------
Tüm Filmleri Al (GET)

Endpoint: /api/Film/TumFilmleriGetir
Bu endpoint, sistemde kayıtlı olan tüm filmleri getirmek için kullanılır.

Request : /api/Film/TumFilmleriGetir

--------------------------------------------------------------------------

ID'ye Göre Film Al (GET)

Endpoint: /api/Film/IdyeGoreFilmGetir
Belirli bir filmi ID'ye göre almak için kullanılır.

Request: /api/Film/IdyeGoreFilmGetir?id={filmId}

--------------------------------------------------------------------------

Filmin Oyuncularını Al (GET)

Endpoint: /api/Film/FilmdekiOyuncularıGetir
Belirli bir filmin ID'sine göre oyuncularını almak için kullanılır.

Request: /api/Film/FilmdekiOyuncularıGetir?id={filmId}

--------------------------------------------------------------------------

Yeni Film Ekle (POST)
Endpoint: /api/Film/FilmEkle
Yeni bir film eklemek için kullanılır.

Request: /api/Film/FilmEkle
{
  "filmAdi": "Yeni Film",
  "kategoriId": 1
}

--------------------------------------------------------------------------

Film Güncelle (PUT)
Endpoint: /api/Film/FilmGuncelle
Belirli bir filmi ID'ye göre güncellemek için kullanılır.

Request: /api/Film/FilmGuncelle?id={filmId}
{
  "filmAdi": "Güncellenmiş Film Adı",
  "kategoriId": 2
}

--------------------------------------------------------------------------

Film Sil (DELETE)
Endpoint: /api/Film/FilmSil
Belirli bir filmi ID'ye göre silmek için kullanılır.

Request: /api/Film/FilmSil?id={filmId}

--------------------------------------------------------------------------
--------------------------------------------------------------------------

Kategori API Dokümantasyonu
--------------------------------------------------------------------------

Tüm Kategorileri Al (GET)

Endpoint: /api/Kategori/TumKategorileriGetir
Bu endpoint, sistemde kayıtlı olan tüm kategorileri getirmek için kullanılır.

Request: /api/Kategori/TumKategorileriGetir

--------------------------------------------------------------------------

ID'ye Göre Kategori Al (GET)

Endpoint: /api/Kategori/IdyeGoreKategoriGetir
Belirli bir kategoriyi ID'ye göre almak için kullanılır.

Request: /api/Kategori/IdyeGoreKategoriGetir?id={kategoriId}

--------------------------------------------------------------------------

Kategorideki Filmleri Al (GET)

Endpoint: /api/Kategori/KategoridekiFilmleriGetir
Belirli bir kategorideki filmleri almak için kullanılır.

Request: /api/Kategori/KategoridekiFilmleriGetir?id={kategoriId}

--------------------------------------------------------------------------

Yeni Kategori Ekle (POST)

Endpoint: /api/Kategori/KategoriEkle
Yeni bir kategori eklemek için kullanılır.

Request: /api/Kategori/KategoriEkle
{
  "kategoriAdi": "Yeni Kategori"
}

--------------------------------------------------------------------------

Kategori Güncelle (PUT)

Endpoint: /api/Kategori/KategoriGuncelle
Belirli bir kategoriyi ID'ye göre güncellemek için kullanılır.

Request: /api/Kategori/KategoriGuncelle?id={kategoriId}
{
  "kategoriAdi": "Güncellenmiş Kategori Adı"
}

--------------------------------------------------------------------------

Kategori Sil (DELETE)

Endpoint: /api/Kategori/KategoriSil
Belirli bir kategoriyi ID'ye göre silmek için kullanılır.

Request: /api/Kategori/KategoriSil?id={kategoriId}

--------------------------------------------------------------------------
--------------------------------------------------------------------------

Oyuncu API Dokümantasyonu
--------------------------------------------------------------------------

Tüm Oyuncuları Al (GET)

Endpoint: /api/Oyuncu/TumOyunculariGetir
Bu endpoint, sistemde kayıtlı olan tüm oyuncuları getirmek için kullanılır.

Request: /api/Oyuncu/TumOyunculariGetir

--------------------------------------------------------------------------

ID'ye Göre Oyuncu Al (GET)

Endpoint: /api/Oyuncu/IdyeGoreOyuncuGetir
Belirli bir oyuncuyu ID'ye göre almak için kullanılır.

Request: /api/Oyuncu/IdyeGoreOyuncuGetir?id={oyuncuId}

--------------------------------------------------------------------------

Yeni Oyuncu Ekle (POST)

Endpoint: /api/Oyuncu/OyuncuEkle
Yeni bir oyuncu eklemek için kullanılır.

Request:/api/Oyuncu/OyuncuEkle

--------------------------------------------------------------------------

Oyuncu Güncelle (PUT)

Endpoint: /api/Oyuncu/OyuncuGuncelle
Belirli bir oyuncuyu ID'ye göre güncellemek için kullanılır.

Request: /api/Oyuncu/OyuncuGuncelle?id={oyuncuId}

--------------------------------------------------------------------------

Oyuncu Sil (DELETE)

Endpoint: /api/Oyuncu/OyuncuSil
Belirli bir oyuncuyu ID'ye göre silmek için kullanılır.

Request: /api/Oyuncu/OyuncuSil?id={oyuncuId}





