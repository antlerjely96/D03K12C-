// See https://aka.ms/new-console-template for more information

using OOP2;

class Program
{
    public static void Main()
    {
        hinh3D h1 = new hinh3D();
        h1.tenHinh = "hinh hop";
        h1.setSoMat(6);
        h1.setSoCanh(12);
        Console.WriteLine("Thong tin hinh 1:");
        Console.WriteLine("Ten hinh: " + h1.tenHinh);
        Console.WriteLine("So mat: " + h1.getSoMat());
        Console.WriteLine("So canh: " + h1.getSoCanh());
    }
}