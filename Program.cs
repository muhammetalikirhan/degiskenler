// See https://aka.ms/new-console-template for more information



using System.Net.Http.Headers;

byte b = 5;         //1 byte (değeri 5 olan bir byte tanımlaması.) 0 ile 255 arasında değer alır.
sbyte c =5;         //1 byte -128 ile 127 arasında değer alır.

short s = 5;        //2 byte -32768 ile 32767 arasında değer alır.
ushort us = 5;      //2 byte  0 ille 65365 arasında değer alır. (unside durumlarında negatif değer alamaz.)

//Integer değerlerine ihtiyaç duyulduğunda değer aralıklarına kaynaklardan bakılabilir.
//İhtiyaç duyulan değer aralıklarına göre seçimler yapılarak fazla yer tutmak yerine işimize yarayan kadarını kullanmak önemli.
Int16 i16 = 2;      //2 byte 
int i = 2;          //4 byte
Int32 i32 = 2;      //4 byte
Int64 i64 = 2;      //8 byte

uint ui = 2;        //4 byte
long l = 4;         //8 byte 
ulong ul = 4;       //8 byte

float f = 5;        //4 byte Reel sayılar için kullanılır.
double d = 5;       //8 byte Reel sayılar için kullanılır.
decimal dc = 5;     //16 byte

char ch = '2';        //2 byte Tek karakter tutmak isterken string yerine char kullanılabilir.
string str = "Muhammetali";  // Sınırsızdır. Tek karekter için tercih edilmemeli

bool b1 = true;
bool b2 = false;


DateTime dt = DateTime.Now;

Console.WriteLine(dt);



object o1 = "x";        // string değer tanımlaması
object o2 = 'y';        // char tanımlaması
object o3 = 4;          // integer değer tanımanması
object o4 = 4.3;        // decimal (reel sayı) tanımlaması

// object her türlü değeri tutabilir. Tüm değişken tipleri bir object dir. Değişkenler object ten türemiştir.


// STRİNG İFADELER

string str0 = null;
string str1 = string.Empty;
str1 = "Muhammetali_KIRHAN";
string ad = "Muhammetali";  // ad ve soyad ayrı ayrı tutulup (tamisim = ad +""+ soyad;) tanımlamasıyla birleştirilebilir.
string soyad = "KIRHAN";
string tamisim = ad +" "+ soyad;

Console.WriteLine(tamisim);


// İNTEGER TANIMLAMA ŞEKİLLERİ

int integer1 = 15;
int integer2 = 3;

int integer = integer1 + integer2;
int integera = integer1 - integer2;
int integerb = integer1 * integer2;
int integerc = integer1 / integer2;

Console.WriteLine(integer);

Console.WriteLine(integera);

Console.WriteLine(integerb);

Console.WriteLine(integerc);



//BOOLEAN TANIMLAMALARI

bool bool1 = 10<2;
bool bool2 = 10>2;

Console.WriteLine(bool1);

Console.WriteLine(bool2);



//DEĞİŞKEN DÖNÜŞÜMLERİ

string stra = "20";
int inta = 23;

string YeniDeger = stra + inta.ToString();

Console.WriteLine(YeniDeger);


int intb = inta + Convert.ToInt32(stra);

Console.WriteLine(intb);

int intc = inta + int.Parse(stra);

Console.WriteLine(intc);


//DATETİME

string tarih = DateTime.Now.ToString("dd.mm.yyyy");

Console.WriteLine(tarih);

string tariha = DateTime.Now.ToString("mm/dd/yyyy");

Console.WriteLine(tariha);

string tarihb = DateTime.Now.ToString("yyyy-mm-dd");

Console.WriteLine(tarihb);


//SAAT

string hour = DateTime.Now.ToString("hh.mm");

Console.WriteLine(hour);

string houra = DateTime.Now.ToString("hh.mm");

Console.WriteLine(houra);