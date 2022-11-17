namespace demo_class;

public class Students
{
    public string hoTen;
    public string gioiTinh;
    public string diaChi;
    public int tuoi;
    public string soDienThoai;
    public string email;

    public void nhap()
    {
        Console.WriteLine("Nhap thong tin sinh vien");
        Console.Write("Ho Ten: ");
        this.hoTen = Console.ReadLine();
        Console.Write("Dia chi: ");
        this.diaChi = Console.ReadLine();
        Console.Write("Gioi tinh: ");
        this.gioiTinh = Console.ReadLine();
        Console.Write("Tuoi: ");
        this.tuoi = int.Parse(Console.ReadLine());
        Console.Write("soDienThoai: ");
        this.soDienThoai = Console.ReadLine();
        Console.Write("Email: ");
        this.email = Console.ReadLine();
    }

    public void hienThi()
    {
        Console.WriteLine("Thong tin sinh vien");
        Console.WriteLine("Ho Ten: " + this.hoTen);
        Console.WriteLine("Dia chi: " + this.diaChi);
        Console.WriteLine("Gioi tinh: " + this.gioiTinh);
        Console.WriteLine("Tuoi: " + this.tuoi);
        Console.WriteLine("soDienThoai: " + this.soDienThoai);
        Console.WriteLine("Email: " + this.email);
    }
}