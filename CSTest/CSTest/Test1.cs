using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    internal class Test1
    {
        //Đây là bài về nhập xuất cơ bản
        public static void Run()
        {
            //Mấy chương trình này chưa bắt lỗi.
            //VD số tuổi có thể nhập bất kì cái gì mà không cần phải yêu cầu nhập đúng kiểu số
            string name1;
            string name2;
            string age2;
            string address2;
            Console.WriteLine("***CHUONG TRINH 1***");
            Console.Write("Nhap ten cua ban: ");
            name1 = Console.ReadLine();
            Console.WriteLine("DuyViet xin chao " + name1);
            //Neu muon chay cai duoi nay thi bo comment
            //Console.WriteLine($"DuyViet xin chao {name1}");
            //Console.WriteLine("DuyViet xin chao {0}",name1);
            Console.WriteLine("");

            Console.WriteLine("***CHUONG TRINH 2***");
            Console.Write("Nhap ten: ");
            name2 = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            age2 = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            address2 = Console.ReadLine();
            Console.WriteLine(name2 + " " + age2 + " " + address2);
            //Neu muon chay cai duoi thi bo comment
            //Console.WriteLine($"{name2} {age2} {address2}");
            //Console.WriteLine("{0}{1}{2}", name2, age2, address2);
        }
    }
}
