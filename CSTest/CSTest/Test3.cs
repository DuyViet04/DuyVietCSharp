using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    internal class Test3
    {
        //Đây là bài về toán tử
        public static void Run()
        {
            Console.WriteLine("***CHUONG TRINH 1***");
            int i = 5, j = 5;

            Console.WriteLine(i++); // Sử dụng giá trị i để in ra rồi mới tăng i
            Console.WriteLine(++j); // Tăng j lên rồi mới in giá trị j ra màn hình

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("***CHUONG TRINH 2***");
            int a, b, c;

            a = b = (c = 9) + 1; // khởi tạo giá trị: a = 10, b = 10, c = 9
            a += b; // tương đương a = a + b
            b = c++; // thực hiện gán giá trị c cho biến b sau đó thực hiện c = c + 1
            --c; // thực hiện c = c - 1

            Console.WriteLine(" a = {0}, b = {1}, c = {2}", a, b, c);

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("***CHUONG TRINH 3***");
            string strSoNguyen; // Biến chứa dữ liệu nhập vào từ bàn phím
            int SoNguyen; // Biến chứa số nhập vào từ bàn phím
            string KetQua; // Biến chứa kết quả kiểm tra số vừa nhập là chẵn hay lẻ

            strSoNguyen = Console.ReadLine(); // Đọc dữ liệu nhập vào từ bàn phím (dữ liệu này ở dạng chuỗi) sau đó gán giá trị vào biến strSoNguyen
            //Câu lệnh trên nếu không nhập số thì sẽ bị lỗi
            //Đó là lí do tại sao phải bắt lỗi nếu vào 1 chương trình cụ thể
            SoNguyen = Int32.Parse(strSoNguyen); // Ép kiểu dữ liệu vừa nhập vào (dạng chuỗi) sang dạng số rồi gán giá trị vào biến SoNguyen
            KetQua = (SoNguyen % 2 == 0) ? "so chan" : "so le"; // Sử dụng toán tử 3 ngôi để kiểm tra số chẵn lẻ

            Console.WriteLine("{0} la {1}", SoNguyen, KetQua); // In kết quả ra màn hình

            Console.ReadKey();

        }
    }
}
