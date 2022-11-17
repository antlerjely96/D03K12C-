// See https://aka.ms/new-console-template for more information

using demo_class;

class Program
{
    public static void Main()
    {
        Students st1 = new Students();
        st1.nhap();
        Console.WriteLine("====================");
        st1.hienThi();
    }
}