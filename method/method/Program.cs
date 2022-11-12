// See https://aka.ms/new-console-template for more information

//Cach de viet chuong trinh thanh tung method
/*
*B1: viet tat ca code vao method main
* B2: tim xem chuong trinh co bao nhieu chuc nang
* B3: tach moi chuc nang thanh 1 method
*/
//Nhap so nguyen n. Tinh n!
class Program
{ 
    /* Cach 1: viet khong dung de quy*/
        //3 method
        //Method nhap n
        public static int nhap()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        //Method tinh n!
        public static int tinh_giai_thua(int n)
        { 
            int giai_thua = 1;
            for (int i = 1; i <= n; i++)
            {
                giai_thua *= i;
            }
            return giai_thua;
        }
    /* Cach 2: viet bang de quy */
    public static int tinh_giai_thua_de_quy(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return n * tinh_giai_thua_de_quy(n - 1);
    }
    public static void Main()
    {
        //Nhap n
        int n = nhap();
        //tinh n!
        Console.WriteLine("---------- tinh thong thuong -----------");
        int giai_thua = tinh_giai_thua(n);
        //in ket qua
        Console.WriteLine("n! = " + giai_thua);
        Console.WriteLine("------ Tinh bang de quy ---------");
        int giai_thua_de_quy = tinh_giai_thua_de_quy(n);
        Console.WriteLine("n! = " + giai_thua_de_quy);
    }
}