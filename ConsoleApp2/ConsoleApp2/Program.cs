// See https://aka.ms/new-console-template for more information

//Nhap a
Console.Write("Nhap a: ");
int a = int.Parse(Console.ReadLine());
//Kiem tra a la so am hay duong
if (a > 0)
{
    if (a % 2 == 0)
    {
        Console.WriteLine(a + " la so duong chan");
    }
    else
    {
        Console.WriteLine(a + " la so duong le");
    }
}
else if (a < 0)
{
    Console.WriteLine(a + " la so am");
}
else
{
    Console.WriteLine(a + " la so khong am khong duong");
}


//Nhap 1 so. hien thi so ngay cua thang do
Console.Write("Nhap thang: ");
int thang = int.Parse(Console.ReadLine());
//Hien thi so ngay trong thang
switch (thang)
{
    case 1:
        Console.WriteLine(thang + " co 31 ngay");
        break;
    case 2:
        //nhap nam
        Console.Write("Nhap nam: ");
        int nam = int.Parse(Console.ReadLine());
        //Kiem tra nam co nhuan khong
        if (nam % 4 == 0)
        {
            Console.WriteLine(thang + " co 29 ngay");
        }
        else
        {
            Console.WriteLine(thang + " co 28 ngay");
        }
        break;
    case 3:
        Console.WriteLine(thang + " co 31 ngay");
        break;
    case 4:
        Console.WriteLine(thang + " co 30 ngay");
        break;
    case 5:
        Console.WriteLine(thang + " co 31 ngay");
        break;
    case 6:
        Console.WriteLine(thang + " co 30 ngay");
        break;
    case 7:
        Console.WriteLine(thang + " co 31 ngay");
        break;
    case 8:
        Console.WriteLine(thang + " co 31 ngay");
        break;
    case 9:
        Console.WriteLine(thang + " co 30 ngay");
        break;
    case 10:
        Console.WriteLine(thang + " co 31 ngay");
        break;
    case 11:
        Console.WriteLine(thang + " co 30 ngay");
        break;
    case 12:
        Console.WriteLine(thang + " co 31 ngay");
        break;
    default:
        Console.WriteLine(thang + " khong ton tai");
        break;
}