
// 1. soru)
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

Console.WriteLine(" Merhaba \n Nasılsın? \n İyiyim \n Sen nasılsın?");




// 2.soru)


string metin = "Kaç yılındayız?";
int sayı = 2023;

Console.WriteLine($"Yapılan atamalar---->{metin} \n {sayı}");

// 3.soru)
{
    Random random = new Random();
    int sayı1 = random.Next(1, 10);
    Console.WriteLine($"Ratgele sayı----->{sayı1}");
}//bu şekilde her soruyu süsülü parantez içine alarak parantez içinde tanımladığım değişkenlerin diğer sorularda kafamı karıştırmasını önlüyorum.

// random sayı tanımlama 

// 4. soru) 
{
    Random random = new Random();
    int sayı1 = random.Next();
    Console.WriteLine("Rastgele sayımız -----" + sayı1);
    int kalan = sayı1 % 3;
    Console.WriteLine("Sayının 3 bölümünden kalan ------>" + kalan);
}

//5. soru)

{
    Console.WriteLine("Lütfen yaşınızı giriniz?");
    int yaş = Convert.ToInt32(Console.ReadLine());
    if (yaş >= 18)
    {
        Console.WriteLine("18 yaşından büyüksünüz +");

    }
    else
    {
        Console.WriteLine("18 yaşından küçüksünüz -");
    }
    // 18 yaşı if bağlacına sokarak girilen değere göre çıktılar alınır 


}

//6.soru)
{

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Sen Vodafone gibi anı yaşa,ben Turkcellgibi seni her yerde çekemem");

    }
    //for döngüsünü tanımlamak diğer döngülere göre daha pratik olduğu için for kullanıyorum
}

//7.soru)
{
    string a = "Burcu Birsen";
    string b = "Demet Evgan";

    Console.WriteLine($"Metot çağırılmadan önce \n a={a} \n b={b}");
    Değiştir(ref a, ref b);
    Console.WriteLine($"Metot çağırıldıktan sonra değişkenler \n a={a} \n b={b} ");

    static void  Değiştir(ref string x, ref string y)
    {
        string temp = x;
        x = y;
        y = temp;
    }

    // ref kullanark kelimeleri değitirebiliyorum 

}
//8.soru)
{
    static void BenDegerDondurmem()//döngüyü geri dödürmeyeceğimiz için void formunda 
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok,bana değişken atamaya çalışma");
    }

    BenDegerDondurmem();

}

//9.soru)
{
    int toplan(int a, int b)// toplamak için dmngü kuruyoruz tam sayılar olduğu için int formunda
    {
        return a + b;

    }

    Console.WriteLine("Toplamak istediğiniz değeri giriniz");
    int k = Convert.ToInt32(Console.ReadLine());
    int l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(toplan(k, l));
}

//10.soru)
{
    string Döngü(bool GirilenDeğer)
    {
        if (GirilenDeğer)
        {
            Console.WriteLine("Doğru cevap verdiniz");
            return "Girilen değer doğru";
        }
        else
        {
            Console.WriteLine("Yalış cevap verdini ");
        return "Girilen değer yanlış";
        }
    }
    Console.WriteLine("Muğlanın plakası 48'dir.");
    string cevap = Console.ReadLine();
    if (cevap == "doğru")
    {
        Döngü(true);
    }
    else if (cevap == "yanlış")
    {
        Döngü(false);
    }
    else
        Console.WriteLine("geçersiz değer girişi yaptınız.");




}
//11.soru)
{

    int DonenYas(int yas1, int yas2, int yas3)
    {
        if (yas1 < yas2 && yas2 < yas3)
        {
            Console.WriteLine($"en yaşlı ------> {yas3}");
            return yas3;
        }

        else if (yas1 < yas3 && yas3 < yas2)
        {
            Console.WriteLine($"En yaşlı -------> {yas2}");
            return yas2;
        }
        else if (yas2 < yas3 && yas3 < yas1)
        {
            Console.WriteLine($"En yaşlı --------> {yas1}");
            return yas1;

        }
        else if (yas3 < yas1 && yas1 < yas2)
        {
            Console.WriteLine($"En yaşlı --------> {yas2}");
            return yas2;
        }
        else if (yas3 < yas2 && yas2 < yas1)
        {
            Console.WriteLine($"En yaşlı ---------> {yas1}");
            return yas1;
        }
        else if (yas2 < yas1 && yas2 < yas1)
        {
            Console.WriteLine($"En yaşlı ------> {yas1}");
            return yas1;
        }

        else
        {
            Console.WriteLine("Lütfen girdiğiniz değerleri kontrol ediniz ");
            return 2;
        }


    }
    Console.WriteLine("1.yaşı giriniz lütfen");
    int yas1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("2.yaşı giriniz");
    int yas2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("3. yaşı giriniz ");
    int yas3 = Convert.ToInt32(Console.ReadLine());
    DonenYas(yas1, yas2, yas3);
}


// 12. soru)  
// Params kullanrak yapmaya çalıştım 

{
    int EnBüyükDeğerSayısı(params int[] numbers)
    {
        int maxSayı = int.MaxValue;
        foreach (int number in numbers)
        {
            maxSayı = Math.Max(number, maxSayı);

        }
        return maxSayı;
    }

    Console.WriteLine("Lütfen boşluk bırakarak sayıları girinzi");
    string input = Console.ReadLine();
    string[] inputs = input.Split(' ');
    int[] numbers = Array.ConvertAll(inputs, int.Parse);
    int maxSayı = EnBüyükDeğerSayısı(numbers);
    Console.WriteLine($"Girdiğiniz en büyük sayı {maxSayı}");


}



//13.soru)
{
  
    void değiştir(ref string x, ref string y)
    {
        String temp = x;
        x = y;
        y = temp;

    }

    Console.WriteLine("Lütfen değiştirilmek istenen isimi giriniz");
    string name = Console.ReadLine();
    Console.WriteLine("Lütfen değiştirilecek 2. isismi yazınız");
    string name1 = Console.ReadLine();

    Console.WriteLine($"Değiştirilmeden isimler -----------> {name} , {name1}");
    değiştir(ref name, ref name1);
    Console.WriteLine($"Değiştirilen isimler --------> {name} , {name1}");
}
//14. soru)
{

    static bool dongu(int number) //2 ye bölüm sonucu çif olduğunu test ediyorum 
    {
        return number % 2 == 0;
    }

    Console.WriteLine("Lütfen sayı giriniz ");
    int kullanıcıSayı = Convert.ToInt32(Console.ReadLine());
    bool abc = dongu(kullanıcıSayı);// abc nin doğru olduğu zamnada if çalışır ve çift mi tek mi olduğu anlaşılır
    if (abc)
    {
        Console.WriteLine("Girdiğiniz sayı çift sayıdır");
    }
    else
    {
        Console.WriteLine("Girdiğiniz sayı tekdir");
    }




}
//15.soru)
{
    int hesaplama(int hız, int zaman)
    {
        return hız * zaman; //hesap işelemini bir metoda tanımlayarak istenen zamanda metodu çağırabilirim
    }
    Console.WriteLine("Lütfen bir hız değeri giriniz\nLütfen bir zaman değeri giriniz");
    int hızGirilen = Convert.ToInt32(Console.ReadLine());
    int zamanGirilen = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(hesaplama(hızGirilen, zamanGirilen));

}
//16.soru)
{

    Console.WriteLine("Lütfen yarıçap giriniz");
    double r = Convert.ToDouble(Console.ReadLine());

    double pi = 3.14;

    double rKare = Math.Pow(r, 2);
    double alan = pi * rKare;
    Console.WriteLine($"Dairenin alanı ------->{alan}");



}
//17.soru)
{
    string text = "Zaman bir GeRi SayIm";
    string up = text.ToUpper();
    string low = text.ToLower();

    Console.WriteLine("Büyük harf ------>" + up);
    Console.WriteLine("Küçük harf ------>" + low);
}
//18.soru)
{
    string text = " Selamalar ";
    String son = text.Trim();
    Console.WriteLine(son);
}