﻿class TestClass
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
    //    switch(choice)
    //    {
    //        case 1:
    //            double sum = resistances[0] + resistances[1] + resistances[2];

    //            Console.WriteLine("your total resistance is {0}", Math.Round(sum,2));
    //            break;
    //        case 2:
    //            double sum2 = 1/((1/resistances[0]) + (1/resistances[1])+ (1/resistances[2]));

    //            Console.WriteLine("your total resistance is {0}", Math.Round(sum2,2));
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


    }

}