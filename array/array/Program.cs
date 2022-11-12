// See https://aka.ms/new-console-template for more information

// Nhap 1 mang so nguyen co n phan tu (n nhap tu ban phim)
// Tinh tong cac phan tu cua mang

//Nhap n
Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine());
//Khai bao mang so nguyen co n phan tu
int[] arr = new int[n];
//Nhap mang
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//Tinh tong cac phan tu cua mang
int tong = 0;
for (int i = 0; i < n; i++)
{
    tong += arr[i];
}
//In ra tong cac phan tu cua mang
Console.WriteLine("Tong cac phan tu cua mang: " + tong);
