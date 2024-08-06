// Bebek sınıfının propertyleri -> Doğum Tarihi , Ad, Soyad 

// Bebek sınıfı için 2 adet constructor tanımlayınız.

// 1.si Default Constructor tarzında parametre almayan bir metot.

// 2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.

// 2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.

// Tanımlama sonrasında her iki constructor ile de birer bebek nesnesi tanımlayarak özelliklerini konsol ekranına yazdırınız.

using PatikaWeek4PracticeConstructor;

// Creating a Baby object using constructor which take parameters
Baby baby1 = new Baby("Bilal", "Bilin");
baby1.BabyInfo();

// Creating a Baby object using default constructor
Baby baby2 = new Baby();
baby2._name = "Ciwan";
baby2._surname = "Ali";
baby2.BabyInfo();