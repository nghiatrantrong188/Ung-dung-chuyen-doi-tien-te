// See https://aka.ms/new-console-template for more information
using System;
namespace UngDungChuyenDoiTienTe
{
    class Program
    {
        static void Main(string[] args)
        {
            float ti_gia;
            float USD;
            Console.Write("Nhap so tien USD muon chuyen doi thanh tien VND: ");
            USD = float.Parse(Console.ReadLine());
            ti_gia = USD * 23000;
            Console.Write("So tien viet ban nhan sau khi chuyen doi la: " + ti_gia + "VND");
            ti_gia = float.Parse(Console.ReadLine());
            int a;
        }
    }
}
