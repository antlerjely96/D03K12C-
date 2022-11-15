// See https://aka.ms/new-console-template for more information

//Nhap va hien thi thong tin cua 5 sinh vien gom ho ten, tuoi, so dien thoai, dia chi

//Khai bao struct sinh vien
struct sinhVien
{ 
    public string hoTen;
    public int tuoi;
    public string soDienThoai;
    public string diaChi;
};

//Khai bao 1 mang 5 phan tu cua struct sinhVien

class Program
{
    public static void Main(string[] args)
    {
        sinhVien[] sv = new sinhVien[5];

        //Nhap
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nhap ho ten sv " + (i + 1) + " : ");
            sv[i].hoTen = Console.ReadLine();
            Console.Write("Nhap tuoi sv " + (i + 1) + " : ");
            sv[i].tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dien thoai sv " + (i + 1) + " : ");
            sv[i].soDienThoai = Console.ReadLine();
            Console.Write("Nhap dia chi sv " + (i + 1) + " : ");
            sv[i].diaChi = Console.ReadLine();
        }
        //hien thi
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thong tin cac sinh vien vua nhap");
            Console.WriteLine("Sinh vien " + (i + 1) + " : ");
            Console.WriteLine("Ho ten: " + sv[i].hoTen);
            Console.WriteLine("Tuoi: " + sv[i].tuoi);
            Console.WriteLine("So dien thoai: " + sv[i].soDienThoai);
            Console.WriteLine("Dia chi: " + sv[i].diaChi);
        }
    }
}