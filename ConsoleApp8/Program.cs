using System.ComponentModel;

string[] objeler = new string[3] {"tas" , "kagit" , "makas"};

int tursayisi = 0;
string girdi = "";
int bilgisayarskor = 0;
int kullanıcıskor = 0;
int beraberskor = 0;
List<string> sonuclar = new List<string>();

Boolean objesectimi = false;
while (true)
{
    objesectimi = false;
    do
    {
        Console.WriteLine("Lütfen bir nesne seçiniz: tas, kagit, makas");
        girdi = Console.ReadLine();
        if (girdi.ToLower() == "bitti")
        {
            break;
        }

        for (int i = 0; i < objeler.Length; i++)
        {
            if (girdi.ToLower() == objeler[i])
            {
                objesectimi = true;
                break;
            }
        }
        if (objesectimi == false)
        {
            Console.WriteLine("Lütfen 3 değerden birini seçiniz.");
        }
    }
    
    while (objesectimi == false);
    if(objesectimi == false)
    {
        break;
    }
    tursayisi++;
    int Randomsayi = Random.Shared.Next(0, 3);
    Console.WriteLine("Bilgisayarın seçimi: " + objeler[Randomsayi]);
    if (objeler[Randomsayi] == girdi.ToLower())
    {
        Console.WriteLine("Berabere");
        beraberskor++;
        sonuclar.Add("Berabere");
    }
    else if ((objeler[Randomsayi] == "tas" && girdi.ToLower() == "makas") || (objeler[Randomsayi] == "kagit" && girdi.ToLower() == "tas") || (objeler[Randomsayi] == "makas" && girdi.ToLower() == "kagit"))
    {
        Console.WriteLine("Bilgisayar kazandı");
        bilgisayarskor++;
        sonuclar.Add("Bilgisayar kazandı");
    }
    else
    {
        Console.WriteLine("Kullanıcı kazandı");
        kullanıcıskor++;
        sonuclar.Add("Kullanıcı kazandı");
    }
}
Console.WriteLine("Kullanıcının skoru: " + kullanıcıskor);
Console.WriteLine("Bilgisayarın skoru: " + bilgisayarskor);
Console.WriteLine("Beraberlik sayısı: " + beraberskor);
Console.WriteLine(tursayisi.ToString() + " adet oyun oynandı. Sonuçlar: " + string.Join(", ", sonuclar));

