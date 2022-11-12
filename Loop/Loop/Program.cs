// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
//Tinh tong cac so tu 1 den 100
/* for */
int i = 1, tong_for = 0;
for (i = 1; i < 100; i++)
{
    tong_for += i;
}
Console.WriteLine("tong cac so tu 1 den 100: " + tong_for);
/* while */
int j = 1, tong_while = 0;
while (j < 100)
{
    tong_while += j;
    j++;
}
Console.WriteLine("tong cac so tu 1 den 100: " + tong_for);
/* do - while*/
int k = 1, tong_do_while = 0;
do
{
    tong_do_while += k;
    k++;
} while(k < 100);
Console.WriteLine("tong cac so tu 1 den 100: " + tong_for);
/* nested loop*/
for (int a = 1; a < 5; a++)
{
    for (int b = 1; b <= a; b++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}