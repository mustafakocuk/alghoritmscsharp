using System.Globalization;
using System.Linq.Expressions;

class TestClass
{
    #region Basic Name Surname

    //static void Main(string[] args)
    //{
    //    string ad, soyad;
    //    Console.WriteLine("Adınız:");
    //    ad = Console.ReadLine();
    //    Console.WriteLine("Soyadınız");
    //    soyad = Console.ReadLine();
    //    Console.WriteLine("Merhaba {0} , {1}.", ad, soyad);
    //    Console.ReadKey();
    //}

    #endregion

    #region Basic Read - Write

    //static void Main(string[] args)
    //{
    //    int num1, num2, sum;
    //    Console.Write("Enter your first number that you want to sum:");
    //    num1 = Convert.ToInt32(Console.ReadLine());
    //    Console.Write("Enter your second number that you want to sum");
    //    num2 = Convert.ToInt32(Console.ReadLine());
    //    sum = num1 + num2;
    //    Console.WriteLine("Result of sum {0} and {1} is equal to {2}",num1,num2,sum);
    //}

    #endregion

    #region Calculator

    //public static double Sum(double num1, double num2)
    //{
    //    return num1 + num2;
    //}
    //public static double Sub(double num1, double num2)
    //{
    //    return num1-num2;
    //}
    //public static double Div(double num1, double num2)
    //{
    //    return num1 / num2;
    //}
    //public static double Mult(double num1, double num2)
    //{
    //    return num1 * num2;
    //}
    //static void Main(string[] args)
    //{
    //    double num1, num2;
    //    Console.Write("Enter your first number:");
    //    num1 = Convert.ToDouble(Console.ReadLine());
    //    Console.Write("Enter your second number");
    //    num2 = Convert.ToDouble(Console.ReadLine());

    //    double sum = Sum(num1, num2);
    //    double sub = Sub(num1, num2);
    //    double div = Div(num1, num2);
    //    double mult = Mult(num1, num2);

    //    Console.WriteLine("{0} + {1} is equal to {2}", num1,num2,sum);
    //    Console.WriteLine("{0} - {1} is equal to {2}", num1,num2,sub);
    //    Console.WriteLine("{0} / {1} is equal to {2}", num1,num2,div);
    //    Console.WriteLine("{0} * {1} is equal to {2}", num1,num2,mult);

    //}

    #endregion

    #region Tax Calculator

    //public static double Tax(double price)
    //{
    //    return (price * 18) / 100;

    //}
    //static void Main(string[] args)
    //{
    //    double price;
    //    Console.WriteLine("enter price of your product:");
    //    price = Convert.ToDouble(Console.ReadLine());
    //    var tax = Tax(price);

    //    Console.WriteLine("The tax of the product you own is {0} ", tax);

    //}
    #endregion

    #region Percentage
    //static void Main(string[] args)
    //{
    //    double num, percentage, result;
    //    Console.WriteLine("enter your number:");
    //    num = Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine("enter your percentage:");
    //    percentage = Convert.ToDouble(Console.ReadLine());
    //    result = num * percentage / 100;
    //    Console.WriteLine($"percentage of number that given is equal to {result}");
    //}
    #endregion

    #region Circle Are and Perimeter (Rounded)
    //public static double Area(double radius)
    //{
    //    double area = Math.PI * radius * radius;
    //    return Math.Round(area,2);
    //}
    //public static double Perimeter(double radius)
    //{
    //    double perimeter = 2 * Math.PI * radius;
    //    return Math.Round(perimeter,2);
    //}
    //static void Main(string[] args)
    //{
    //    double radius;
    //    Console.Write("enter radius of the circle: ");
    //    radius = Convert.ToDouble(Console.ReadLine());
    //    double area = Area(radius);
    //    double perimeter = Perimeter(radius);
    //    Console.WriteLine("Area of the circle is {0} and perimeter of the circle is {1}",area,perimeter);

    //}
    #endregion

    #region Grade Calculation ( if else )
    //static void Main(string[] args)
    //{
    //    double visa, final, homework, ratio;
    //    Console.WriteLine("Your visa grade is: ");
    //    visa = Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine("Your final grade is: ");
    //    final = Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine("your homework grade is: ");
    //    homework = Convert.ToDouble(Console.ReadLine());
    //    ratio = (visa * 0.4) + (final * 0.5) + (homework * 0.1);
    //    Console.WriteLine("your last grade is {0}", ratio);

    //    if(ratio > 50)
    //    {
    //        Console.WriteLine("Succeed");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Failed");
    //    }

    //}
    #endregion

    #region Compare Numbers ( if - else if)
    //static void Main(string[] args)
    //{
    //    int num1, num2;
    //    Console.WriteLine("enter your first number: ");
    //    num1 = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("enter your second number: ");
    //    num2 = Convert.ToInt32(Console.ReadLine());

    //    if (num1 > num2)
    //    {
    //        Console.WriteLine("num1 is greater");
    //    }
    //    else if (num1 == num2)
    //    {
    //        Console.WriteLine("these numbers is equal");
    //    }
    //    else
    //    {
    //        Console.WriteLine("num2 is greater");
    //    }
    //    Console.ReadKey();
    //}
    #endregion

    #region Odd-Even Number Control ( if else)
    //static void Main(string[] args)
    //{
    //    int num;
    //    Console.WriteLine("Please enter your number; ");
    //    num = Convert.ToInt32(Console.ReadLine());
    //    if (num % 2 == 0)
    //    {
    //        Console.WriteLine("number is even");
    //    }
    //    else
    //    {
    //        Console.WriteLine("number is odd");
    //    }
    //    Console.ReadKey();
    //}
    #endregion

    #region Positive-Negative ( if else if else)
    //static void Main(string[] args)
    //{
    //    int number;
    //    Console.WriteLine("enter your number");
    //    number = Convert.ToInt32(Console.ReadLine());
    //    if (number < 0)
    //    {
    //        Console.WriteLine("number is negative");
    //    }
    //    else if (number == 0)
    //    {
    //        Console.WriteLine("number is zero");
    //    }
    //    else
    //    {
    //        Console.WriteLine("number is positive");
    //    }
    //    Console.ReadKey();

    //}
    #endregion

    #region Divisibility Test for 4 and 7 (if else while)
    //static void Main(string[] args)
    //{

    //    var i = 0;  
    //    while (i <= 3)
    //    {
    //         int number;
    //         Console.WriteLine("enter your number for testing: ");
    //         number = Convert.ToInt32(Console.ReadLine());

    //         if(number%4==0 && number % 7 == 0)
    //         {
    //             Console.WriteLine("{0} is divisible for 4 and 7",number);
    //         }
    //         else
    //         {
    //           Console.WriteLine("{0} is not divisible for 4 and 7", number);
    //         }
    //         i++;

    //    }


    //}
    #endregion

    #region 0-100 Range(if else)
    //static void Main(string[] args)
    //{
    //    int number;
    //    Console.WriteLine("enter your number: ");
    //    number = Convert.ToInt32(Console.ReadLine());

    //    if(number>0 && number <= 100)
    //    {
    //        Console.WriteLine("number is at range");
    //    }
    //    else
    //    {
    //        Console.WriteLine("not range");
    //    }

    //}
    #endregion

    #region Direnç Hesaplama(for - switch case)

    //static void Main(string[] args)
    //{
    //    double[] resistances = new double[3];
    //    Console.WriteLine("Enter your value of resistance: ");
    //    for (int i = 0; i < resistances.Length; i++)
    //    {
    //        resistances[i] = Convert.ToDouble(Console.ReadLine());
    //    }
    //    int choice;
    //    Console.WriteLine("enter your type of connection: \n 1 for series \t 2 for parallel");
    //    choice = Convert.ToInt32(Console.ReadLine());
    //    switch (choice)
    //    {
    //        case 1:
    //            double sum = resistances[0] + resistances[1] + resistances[2];

    //            Console.WriteLine("your total resistance is {0}", Math.Round(sum, 2));
    //            break;
    //        case 2:
    //            double sum2 = 1 / ((1 / resistances[0]) + (1 / resistances[1]) + (1 / resistances[2]));

    //            Console.WriteLine("your total resistance is {0}", Math.Round(sum2, 2));
    //            break;
    //        default:
    //            Console.WriteLine("your value is not exist at the choice");
    //            break;

    //    }


    //}
    #endregion

    #region 50 den büyük sayıların toplamı ( List - array )
    //static void Main(string[] args)
    //{

    //    int[] array = new int[10];
    //    List<int> list = new List<int>();


    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz. ");
    //        array[i] = Convert.ToInt32(Console.ReadLine());
    //        if (array[i] >= 50)
    //        {
    //            list.Add(array[i]);

    //        }
    //    }

    //    for(int i = 0; i < array.Length; i++)
    //    {
    //        Console.Write(array[i] + "\t");
    //    }
    //    Console.WriteLine("");

    //    list.ForEach(num => Console.Write(num + ", "));

    //    int total = list.Sum(x => Convert.ToInt32(x));
    //    Console.WriteLine("");
    //    Console.WriteLine("50 den büyük elemanların toplamı" + total);


    //}
    #endregion


    static void Main(string[] args)
    {
        #region Tek çift random sayılar
        //Random number = new Random();
        //List<int> list = new List<int>();
        //int a = 0;
        //int b = 0;

        //for (int i = 0; i < 10; i++)
        //{
        //    list.Add(number.Next(1,100));
        //    if (list[i] % 2 == 0)
        //    {
        //        a++;
        //    }
        //    else
        //    {
        //        b++;
        //    }
        //}
        //Console.WriteLine("tek sayıların adedi = {0}, çift sayıların adedi = {1}",b,a);
        //list.ForEach(num => Console.Write(num + ","));
        #endregion

        #region Random 50den büyük olan sayıların toplamı

        //Random random = new Random();
        //int sayi;
        //int toplam = 0;
        //double ort;
        //int sayac = 0;
        //for(int i = 0; i < 10; i++)
        //{
        //    sayi = random.Next(1, 100);
        //    Console.WriteLine(sayi);
        //    if (sayi > 50)
        //    {
        //        toplam += sayi;
        //        sayac ++;
        //    }
        //}
        //ort = toplam / sayac;
        //Console.WriteLine("10 adet sayı arasından 50 den büyük olan {0} sayı vardır, oralaması {1}'dır",sayac,ort);
        #endregion

        #region Girilen 10 sayının toplamı
        //int toplam = 0;
        //int sayi;
        //Console.WriteLine("10 adet sayı giriniz;");
        //for(int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("{0}. sayıyı girniz",i+1);
        //    sayi = Convert.ToInt32(Console.ReadLine());
        //    toplam += sayi;
        //}

        //Console.WriteLine("Sayıların toplamı {0}'dır",toplam);
        #endregion

        #region baslangic ve bitis değerleri ve artis değeri kullanıcı tarafından girilen sayıları ekrana yazdırma
        //int baslangic;
        //int bitis;
        //int artis;
        //Console.WriteLine("baslangic sayisini giriniz: ");
        //baslangic = Int32.Parse(Console.ReadLine());
        //Console.WriteLine("bitis sayisini giriniz: ");
        //bitis = Int32.Parse(Console.ReadLine());
        //Console.WriteLine("artis miktarini giriniz: ");
        //artis = Int32.Parse(Console.ReadLine());

        //for (int i = baslangic; i <= bitis; i += artis)
        //{
        //    Console.Write(i + ",");
        //}
        #endregion

        #region Asal Sayıları Bulma
        //List<int> list = new List<int>();
        //int sayac;
        //for(int i = 2; i < 10000; i++)
        //{
        //    sayac = 0;
        //    for(int j = 2; j <=i/2; j++)
        //    {
        //        if(i%j == 0)
        //        {

        //            sayac++;
        //            break;

        //        }
        //    }
        //    if(sayac == 0)
        //    {
        //        list.Add(i);    
        //    }

        //}

        //Console.WriteLine("1 ile 1.000.000 arasındaki asal sayılar aşağıdadır");
        //list.ForEach(x=>Console.WriteLine(x));
        #endregion

        #region Girilen sayının asal olup olmadığını bulma
        //int num;
        //Console.WriteLine("Kontrol etmek istediğiniz sayıyı giriniz:");
        //num = Convert.ToInt32(Console.ReadLine());
        //int sayac = 0;
        //for(int i = 2; i < num; i++)
        //{
        //    if (num % i == 0)
        //    {
        //        sayac++;
        //    }

        //}
        //if(sayac == 0)
        //{
        //    Console.WriteLine("asal sayı");
        //}
        //else
        //{
        //    Console.WriteLine("asal değildir");
        //}
        #endregion

        #region Yas Hesabı 
        //DateTime dgunu = new DateTime(1990, 12, 15);
        //DateTime simdi = DateTime.Today;
        //int yas = simdi.Year - dgunu.Year;
        //if (dgunu > simdi.AddYears(-yas))
        //    yas--;

        //Console.WriteLine(yas);
        #endregion

        #region Word Counter

        //Console.WriteLine("Enter your sentence: ");
        //string text = Console.ReadLine();
        //Console.WriteLine(text + "\n");
        //string list = "AEOUI";

        //string textUpper = text.ToUpper();
        //int sayac = 0;
        //for (int i = 0; i < textUpper.Length; i++)
        //{
        //    if (list.Contains(textUpper[i]))
        //        sayac++;
        //}
        //Console.WriteLine("Yukarıdaki girdiğiniz - {0} - cümlesinde {1} adet sesli harf vardır", textUpper, sayac);
        #endregion

        #region Calculator withour division incrementor (TAMAMLANMADI)
        //Console.WriteLine("enter your number that you want to divide: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("enter number that make dividing: ");
        //int div = Convert.ToInt32(Console.ReadLine());
        //int sayac = 0;
        //for (int i = number; i >= 0; i -= div)
        //{



        //    if (i < div)
        //    {
        //        int kalan = i;
        //        Console.WriteLine("kalan sayı {0}", kalan);
        //        break;

        //    }
        //    sayac++;

        //}

        //Console.WriteLine("your {0} number is contains {1} amount of {2}", number, sayac, div);
        #endregion

        #region Kare Piramidal Sayılar
        //int toplam;
        //Console.WriteLine("N: ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //string a;

        //for(int i = 1; i <= n; i++)
        //{
        //    toplam = 0;
        //    for (int j = 1; j <= i; j++)
        //    {
        //        toplam += j * j;
        //        Console.Write(j+"^2");
        //        if(j != i)
        //        {
        //            Console.Write(" + ");
        //        }
        //        else
        //        {
        //            Console.Write( " = ");
        //        }

        //    }
        //    Console.Write(toplam);
        //    Console.WriteLine("");
        //}
        #endregion

        #region DersProgramı class
        //string k = "*";
        //int x = 0, y = 3, a = 15;

        //string[,] dizi = {
        //        { "Pazartesi", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
        //        { "Salı", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
        //        { "Çarşamba", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
        //        { "Perşembe", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
        //        { "Cuma", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
        //    };
        //Console.SetCursorPosition(x, 0);
        //Console.WriteLine(tekrarla(75, k));
        //Console.WriteLine("{0} DERS PROGRAMI {0}", tekrarla(30, k));
        //Console.WriteLine(tekrarla(75, k));
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 9; j++)
        //    {
        //        Console.SetCursorPosition(x, y);
        //        Console.Write(k + " ");
        //        Console.Write(dizi[i, j]);
        //        y = y + 1;
        //        if (j == 0)
        //        {
        //            Console.SetCursorPosition(x, y);
        //            Console.Write(k);
        //            Console.Write(tekrarla(a, k));
        //            y = y + 1;
        //        }
        //    }
        //    y = 3;
        //    x = x + a;

        //}
        //Console.WriteLine();
        //Console.WriteLine(tekrarla(75, k));
        //Console.WriteLine(tekrarla(75, k));
        //for (int i = 0; i < 14; i++)
        //{
        //    Console.SetCursorPosition(x - 1, i);
        //    Console.Write("*");
        //}
        //Console.ReadKey();
        #endregion

        #region Ebebek

        //string name;
        //double salary;
        //int hiringYear;
        //int workingHours;


        //Console.WriteLine("Please enter your name: ");
        //name = Console.ReadLine();
        //Console.WriteLine("Please enter your salary: ");
        //salary = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please enter your hiring year: ");
        //hiringYear = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please enter your weekly working hours: ");
        //workingHours = Convert.ToInt32(Console.ReadLine());
        //Console.Clear();



        //Console.WriteLine("Mr/Ms {0}; ", name);
        //raise(salary, hiringYear, workingHours);


        #endregion

        #region Fibonacci is finished now

        //int step;
        //Console.WriteLine("How much step fibonacci series that you want?");
        //step = Convert.ToInt32(Console.ReadLine());
        //int a = 1;
        //int b = 0;
        //int sonuc;
        //for (int i = 0; i < step; i++)
        //{
        //    sonuc = a + b;
        //    a = b;
        //    b = sonuc;

        //    Console.Write(sonuc + ",");
        //}
        #endregion

        #region Kelime Sıralama
        //int adet;
        //Console.Write("Girilecek Veri Adeti : ");
        //adet = Convert.ToInt16(Console.ReadLine());

        //Console.WriteLine("---------------------------------------");
        //string[] liste = new string[adet];
        //string isim;

        //for (int i = 0; i < adet; i++)
        //{
        //    Console.Write(i + 1 + ". İsmi Giriniz: ");
        //    isim = Console.ReadLine();
        //    liste[i] = isim;
        //}

        //Console.WriteLine();
        //Console.WriteLine("Sıralamadan önce liste:");
        //Console.WriteLine("---------------------------------------");

        //foreach (string eleman in liste)
        //{
        //    Console.WriteLine(eleman);
        //}


        //Array.Sort(liste);
        //Console.WriteLine();
        //Console.WriteLine("A-Z Sıralama:");
        //Console.WriteLine("---------------------------------------");

        //foreach (string eleman in liste)
        //{
        //    Console.WriteLine(eleman);
        //}
        //Console.WriteLine();
        //Array.Reverse(liste);
        //Console.WriteLine("Z-A Sıralama:");
        //Console.WriteLine("---------------------------------------");

        //foreach (string eleman in liste)
        //{
        //    Console.WriteLine(eleman);
        //}


        #endregion

        #region Çarpım Tablosu 2
        //Console.WriteLine("Çarpım Tablosuna Hoşgeldiniz: ");
        //int sonuc = 0;
        //for (int i = 1; i <= 10; i++)
        //{
        //    for (int j = 1; j <= 10; j++)
        //    {
        //        sonuc = i * j;
        //        Console.WriteLine("{0} x {1} = {2}", i, j, sonuc);
        //    }
        //    Console.WriteLine("--------------------------------------");
        //}
        #endregion

        #region Anagram

        //Console.WriteLine("İlk kelimeyi giriniz: ");
        //string kelime1 = Console.ReadLine();
        //Console.WriteLine("İkinci kelimeyi giriniz: ");
        //string kelime2 = Console.ReadLine();

        //char[] karakter1 = kelime1.ToLower().ToCharArray();
        //char[] karakter2 = kelime2.ToLower().ToCharArray();

        //Array.Sort(karakter1);
        //Array.Sort(karakter2);

        //string yeniKelime = new string(karakter1);
        //string yeniKelime2 = new string(karakter2);

        //if (yeniKelime==yeniKelime2)
        //{
        //    Console.WriteLine("Bu kelime anagram");
        //}
        //else
        //{
        //    Console.WriteLine("değildir");
        //}
        #endregion

        #region Kare Çizdirme 
        //int size = 20;

        //for (int i = 0; i < size; i++)
        //{
        //    for (int j = 0; j < size; j++)
        //    {
        //        if (i == 0 || i == size - 1 || j == 0 || j == size - 1 || i == j || (i + j) == size - 1)
        //        {
        //            Console.Write("* ");
        //        }
        //        else
        //        {
        //            Console.Write("  ");
        //        }
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region Üçgen Çizdirme ( DİK)

        //for (int i = 0; i < 20; i++)
        //{
        //    string triangle = new String('*', i);
        //    Console.WriteLine(triangle);
        //}
        #endregion

        #region Üçgen Çizdirme ( EŞkenar ) 
        //Console.WriteLine("Üçgenin boyutunu giriniz:  ");
        //int n = int.Parse(Console.ReadLine());
        //string start = new string(' ', n+1);
        //Console.WriteLine(start + "*");
        //for (int i = 0; i < n; i++)
        //{
        //    string startspace = new string(' ', n - i);
        //    string endLine = new string('*', ((2*n)+3));
        //    string space = new String(' ', i);
        //    Console.WriteLine(startspace + "*" + space + "*" + space + "*");
        //    if (i == n-1)
        //    {
        //        Console.Write(endLine);
        //    }

        //}

        #endregion

        #region Üçgen 2

        //int size = 21;

        //for (int i = 0; i < size; i += 2)
        //{
        //    for (int j = 0; j < size; j++)
        //    {
        //        if (i == size -1 || i  == j || (i  + j) == (size-1)/2)
        //        {
        //            Console.Write("* ");
        //        }
        //        else
        //        {
        //            Console.Write("  ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        #endregion

        #region Daire
        //double radius;
        //double thickness = 0.4;
        //ConsoleColor BorderColor = ConsoleColor.Red;
        //Console.ForegroundColor = BorderColor;
        //char symbol = '*';

        //do
        //{
        //    Console.Write("Enter radius:::: ");
        //    if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
        //    {
        //        Console.WriteLine("radius have to be positive number");
        //    }
        //}
        //while (radius <= 0);

        //Console.WriteLine();
        //double rIn = radius - thickness, rOut = radius + thickness;

        //for (double y = radius; y >= -radius; --y)
        //{
        //    for (double x = -radius; x < rOut; x += 0.5)
        //    {
        //        double value = x * x + y * y;
        //        if (value >= rIn * rIn && value <= rOut * rOut)
        //        {
        //            Console.Write(symbol);
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadKey();
        #endregion

        #region Sayı Kaç Basamaklı
        //Console.Write("Bir sayi giriniz: ");
        //int sayi = Convert.ToInt32(Console.ReadLine());
        //int sayac = 0;
        //while (sayi > 0)
        //{
        //    sayi /= 10;
        //    sayac++;
        //}
        //Console.WriteLine("Girdiginiz sayi " + sayac + " basamaklıdır.");
        #endregion

        #region Armstrong
        //Console.WriteLine("Please enter your number that you want to test (a number should be three digit number)");
        //int a = Convert.ToInt32(Console.ReadLine());

        //if (Basamak(a) == true)
        //{

        //    double hundreds = a / 100;
        //    Math.Floor(hundreds);
        //    //Console.WriteLine(hundreds);
        //    double tens = Math.Floor((a - (hundreds * 100)) / 10);
        //    //Console.WriteLine(Math.Floor(tens));
        //    double ones = (a - (hundreds * 100) - (Math.Floor(tens) * 10));
        //    //Console.WriteLine(ones);

        //    if (a == ((hundreds * hundreds * hundreds) + (tens * tens * tens) + (ones * ones * ones)))
        //    {
        //        Console.WriteLine("this is an armstrong number");
        //    }
        //    else
        //    {
        //        Console.WriteLine("it is not an armstrong number");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("number has more 3 digits");
        //}

        #endregion

        #region Pallindrome

        //Console.WriteLine("Enter your word that you want to test: ");
        //string pal = Console.ReadLine();

        //char[] charArray = pal.ToCharArray();
        //Array.Reverse(charArray);
        //string palrev = new string(charArray);
        //Console.WriteLine(palrev);

        //if (pal == palrev)
        //{
        //    Console.WriteLine("it is palindrome");
        //}
        //else
        //{
        //    Console.WriteLine("it is not");
        //}
        #endregion

        #region Second Biggest number in array

        //int[] myArray = {1, 2, 7 , 8, 5,6,9,3};
        //int largest = 0;
        //int secondLargest = 0;

        //for(int i = 0; i < myArray.Length; i++)
        //{
        //    if(myArray[i] > largest)
        //    {
        //        largest = myArray[i];
        //    }
        //}
        //myArray = myArray.Where(x => x != largest).ToArray(); // Diziden eleman çıkarma.

        //for(int i = 0; i < myArray.Length; i++)
        //{
        //    if (myArray[i] > secondLargest)
        //    {
        //        secondLargest = myArray[i];
        //    }
        //}
        //Console.WriteLine("------------");
        //Console.WriteLine(secondLargest);

        #endregion

        #region Word Counter

        //harfSay(Console.ReadLine(),int.Parse(Console.ReadLine()));

        #endregion

        #region Odd - Even number finder
        //Console.WriteLine("Tek sayılardan oluşan listenizin uzunluğunu giriniz: ");
        //int a = int.Parse(Console.ReadLine());
        //int[] yourArray = new int[a];
        //for(int j = 0; j < yourArray.Length; j++)
        //{
        //    Console.WriteLine("Listenizin {0} elemanını giriniz: ", j+1);
        //    yourArray[j] = int.Parse(Console.ReadLine());

        //}
        //Array.Sort(yourArray);
        //List<int> list = new List<int>();
        ////int test;
        //int sayac = 0;
        //for(int i = yourArray[0]; i < yourArray[a-1] ; i += 2)
        //{
        //    //test = i;
        //    if (!yourArray.Contains(i))
        //    {
        //        list.Add(i);
        //    }
        //}

        //for (int k = 0; k < list.Count(); k++)
        //{
        //    Console.WriteLine(list[k]);
        //}

        #endregion

        #region int to binary

        //Console.WriteLine("please enter your number that you want to convert int to binary: ");
        //int bölüm = int.Parse(Console.ReadLine());
        //int kalan;

        //List<int> list = new List<int>();


        //while (bölüm != 1)
        //{
        //    kalan = (bölüm % 2);
        //    list.Add(kalan);
        //    bölüm = bölüm / 2;        
        //}

        //list.Reverse();
        //list.Insert(0, 1);
        //for(int i = 0; i < list.Count(); i++)
        //{
        //    Console.Write(list[i]);
        //}

        #endregion

        #region binary to int hileli

        //Console.WriteLine("Write a number that you want to convert binary to int: ");
        //string a = Console.ReadLine();

        //List<int> list = new List<int>();

        //for(int i = 0; i < a.Length; i++)
        //{
        //    int b = Convert.ToInt32(a[i]);
        //    list.Add(b-48);
        //}


        //list.Reverse();
        //double toplam = 0;
        //for (int i = 0; i < a.Length; i++)
        //{

        //    toplam += list[i] * Math.Pow(2, i);
        //}
        //Console.WriteLine(toplam);

        #endregion

        #region Remove even integers from an array ( with method)

        //List<int> arr = new List<int>();   
        //Console.WriteLine("Before remove even: ");
        //for (int i = 0; i < 10; i++)
        //{
        //    arr.Add(i);  // assignign values
        //    Console.WriteLine(arr[i] + "");
        //}
        //Console.WriteLine("");
        //arr = removeEven(arr, 10); // calling removeEven
        //Console.WriteLine("After remove even: ");
        //for (var i = 0; i < 5; i++)
        //{
        //    Console.WriteLine(arr[i] + ""); // printing array
        //}
        //Console.WriteLine("");
        //return;


        #endregion

        #region Remove Duplicates from List

        //Console.WriteLine("---------------------------"); 
        //List<int> list = new List<int>() { 7,14,21,14,7,14,7};
        //removeDuplicate(list);

        #endregion

        #region another type of pallindrome
        //string a = "kelek";
        //bool b = false;
        //for(int i = 0; i < a.Length; i++)
        //{
        //    if(a[i] == a[(a.Length-1) - i])
        //    {
        //        b = true;
        //    }
        //    else
        //    {
        //        b = false;
        //        break;
        //    }
        //}

        //if (b == false)
        //{
        //    Console.WriteLine("bir palindrome değildir");
        //}
        //else if( b == true)
        //{
        //    Console.WriteLine("palindrome kelime"); 
        //}
        #endregion

        #region Sorting withour sort built in method

        //int[] arr = new int[] { 9,8,7,6,3,2 };
       
        //bool sorted = false;
        //while (!sorted)
        //{
        //    sorted = true;
        //    for (int i = 0; i < arr.Length - 1; i++)
        //            {
               
        //                if (arr[i] > arr[i + 1])
        //                {
        //                    int temp = arr[i];
        //                    arr[i] = arr[i + 1];
        //                    arr[i + 1] = temp;
        //                    sorted = false;
        //                }
        //            }
        //}

        

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        #endregion


    }


    #region Remove Duplicates from List

    //public static List<int> removeDuplicate(List<int> Arr)
    //{
    //    for(int i = 0; i < Arr.Count; i++)
    //    {
    //        for(var j = i+1; j < Arr.Count; j++)
    //        {
    //            if (Arr[i] == Arr[j])
    //            {
    //                Arr.RemoveAt(j);
    //                j--;
    //            }
    //        }
    //        Console.WriteLine(Arr[i]);
    //    }

    //    return Arr;
    //}

    #endregion

    #region Word Counter Method
    //private static void harfSay(string cumle,int sayac2)
    //{
    //    if (sayac2 > 0)
    //    {
    //        if (!string.IsNullOrWhiteSpace(cumle))
    //        {
    //            int sayac = cumle.Length;
    //            string harf = cumle.Substring(0, 1);
    //            cumle = cumle.Replace(harf, "");
    //            sayac -= cumle.Length;
    //            Console.WriteLine($"{harf} -> {sayac} Adet");
    //            harfSay(cumle,sayac2);
    //        }
    //        else if(sayac2>0)
    //        {
    //            sayac2--;
    //            harfSay(Console.ReadLine(),sayac2);
    //        }
    //    }

    //}
    #endregion

    #region EBebek method
    //static void raise(double salary, int hiringYear, int workingHours)
    //{


    //    DateTime nowYear = DateTime.Now;
    //    int a = nowYear.Year;

    //    int workingYear = a - hiringYear;

    //    if (workingYear == 0 && workingYear <= 5)
    //    {
    //        salary = salary * 1.1;
    //        Console.WriteLine("This is your new salary {0}", salary + bonus(workingHours));
    //    }
    //    else if (workingYear > 5 && workingYear <= 10)
    //    {
    //        salary = salary * 1.3;
    //        Console.WriteLine("This is your new salary {0}", salary + bonus(workingHours));
    //    }
    //    else if (workingYear > 10) ;
    //    {
    //        salary = salary * 1.6;
    //        Console.WriteLine("This is your new salary {0}", salary + bonus(workingHours));
    //    }
    //}
    //static int bonus(int workingHours)
    //{
    //    int prim;
    //    if (workingHours == 0 && workingHours <= 45)
    //    {
    //        prim = 0;
    //        Console.WriteLine("priminiz {0} tl'dir", prim);
    //    }
    //    else
    //    {
    //        prim = (workingHours - 45) * 30;
    //        Console.WriteLine("priminiz {0} tl'dir", prim);
    //    }
    //    return prim;
    //}
    #endregion

    #region DersProgramı metod
    //static string tekrarla(int sayi, string karakter)
    //{
    //    string yazi = "";
    //    for (int i = 0; i < sayi; i++)
    //    {
    //        yazi += karakter;
    //    }
    //    return yazi;
    //}
    #endregion

    #region Remove Even Metod 

    //static List<int> removeEven(List<int>Arr, int size)
    //{
    //    int m = 0;
    //    List<int> list = new List<int>();
    //    for(int i = 0; i < size; i++)
    //    {
    //        if (Arr[i]%2 != 0)
    //        {
    //            list.Add(Arr[i]);
    //            ++m;
    //        }
    //    }


    //    return list;
    //}

    #endregion

    #region Armstrong Metod

    //public static bool Basamak(int sayi)
    //{

    //    int sayac = 0;
    //    while (sayi > 0)
    //    {
    //        sayi /= 10;
    //        sayac++;

    //    }

    //    if (sayac == 3)
    //    {

    //        return true;
    //    }
    //    else
    //    {

    //        return false;
    //    }

    //}
    #endregion
}