// See https://aka.ms/new-console-template for more information

using System.Collections;
using QuanLySinhVien;

public class Program
{
    public static void Main()
    {
        int n;
        List<sinhVien> DanhSachSinhVien = new List<sinhVien>();
        sinhVien sv = new sinhVien();
        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Hien thi danh sach sinh vien");
            Console.WriteLine("2. Hien thi danh sach sinh vien theo lop");
            Console.WriteLine("3. Them sinh vien");
            Console.WriteLine("4. Sua thong tin sinh vien");
            Console.WriteLine("5. Xoa sinh vien");
            Console.WriteLine("6. Thoat");
            Console.Write("Chon: ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    sv.hienThi(DanhSachSinhVien);
                    break;
                case 2:
                    sv.hienThiTheoLop(DanhSachSinhVien);
                    break;
                case 3:
                    sv.nhap(DanhSachSinhVien);
                    break;
                case 4:
                    sv.suaSinhVien(DanhSachSinhVien);
                    break;
                case 5:
                    sv.xoaSinhVien(DanhSachSinhVien);
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Chon sai");
                    break;
            }
        } while (n != 6);
    }
}