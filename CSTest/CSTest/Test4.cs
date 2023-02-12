using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    internal class Test4
    {
        //Bài này về ép kiểu
        public static void Run()
        {
            //Đây là ép kiểu ngầm định
            //Ép từ kiểu có miền nhỏ hơn sang miền lớn hơn
            Console.WriteLine("***CHUONG TRINH 1***");
            //int intValue = 10;
            //long longValue = intValue; /* Chuyển kiểu ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int nên có thể chuyển từ int sang long.*/
            float floatValue = 10.9f;
            double doubleValue = floatValue; /* Tương tự vì kiểu double có miền giá trị lớn hơn kiểu float nên có thể chuyển từ float sang double.*/
            Console.WriteLine("");

            //Đây là ép kiểu tường minh
            Console.WriteLine("***CHUONG TRINH 2***");
            int i = 300; // 300 có mã nhị phân là 100101100
            byte b = (byte)i;
            /* do kiểu byte có giới hạn đến giá trị 255 thôi nên không thể chứa số 300 được mà kiểu byte có kích thước là 1 bytes tương đương 8 bit. Như vậy ta cần cắt mã nhị phân của số 300 về còn 8 bit là được. Mã nhị phân 300 là 100101100 cắt từ trái qua 1 bit ta được 00101100 (đủ 8 bit) tương đương với số 44. Cuối cùng biến b sẽ mang giá trị là 44.*/

            Console.WriteLine(" i = " + i);
            Console.WriteLine(" b = " + b);
            Console.WriteLine("");

            Console.WriteLine("***CHUONG TRINH 3***");
            double d = 2 / 3; // kết quả ra 0 vì 2 và 3 đều là số nguyên nên thực hiện 2 chia lấy phần nguyên với 3 được 0
            double k = (double)2 / 3; // Ép kiểu số 2 từ kiểu nguyên sang kiểu số thực. Như vậy kết quả phép chia sẽ ra số thực
            double t = 1.0 * 2 / 3; // Thực hiện nhân 1.0 với 2 mục đích để biến số 2 (số nguyên) thành 2.0 (số thực)

            Console.WriteLine(" d = {0} \n k = {1} \n t = {2}", d, k, t);
            Console.WriteLine("");

            //Đây là ép biến sử dụng phương thức, lớp hỗ trợ sẵn
            Console.WriteLine("***CHUONG TRINH 4***");
            string stringValue = "10";
            int intValue = int.Parse(stringValue); // Chuyển chuỗi stringValue sang kiểu int và lưu giá trị vào biến intValue - Kết quả intValue = 10
            double HowKteam = double.Parse("10.9"); // Chuyển chuỗi giá trị hằng "10.9" sang kiểu int và lưu giá trị vào biến HowKteam - Kết quả HowKteam = 10.9
            Console.WriteLine("");

            Console.WriteLine("***CHUONG TRINH 5***");
            int Result; // Biến chứa giá trị kết quả khi ép kiểu thành công
            bool isSuccess; // Biến kiểm tra việc ép kiểu có thành công hay không
            string Data1 = "10", Data2 = "Kteam"; // Dữ liệu cần ép kiểu

            isSuccess = int.TryParse(Data1, out Result); // Thử ép kiểu Data1 về int nếu thành công thì Result sẽ chứa giá trị kết quả ép kiểu và isSuccess sẽ mang giá trị true. Ngược lại Result sẽ mang giá trị 0 và isSuccess mang giá trị false
            Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Sử dụng toán tử 3 ngôi để in ra màn hình việc ép kiểu đã thành công hay thất bại.
            Console.WriteLine(" Result = " + Result); // In giá trị Result ra màn hình

            isSuccess = int.TryParse(Data2, out Result); // Tương tự như trên nhưng thao tác với Data2
            Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Tương tự như trên
            Console.WriteLine(" Result = " + Result); // Tương tự như trên
            Console.WriteLine("");

            //Muốn chạy chương trình này thì bỏ comment
            //Console.WriteLine("***CHUONG TRINH 6***");
            //int A, B; // Biến chứa giá trị 2 số vừa nhập vào (kiểu số)
            //int Tong, Hieu, Tich; // Biến chứa kết quả tổng, hiệu, tích
            //double Thuong; // Vì phép chia có thể cho ra số thập phân nên dùng biến kiểu double để chứa nó.
            //string strA, strB; // Biến chứa giá trị 2 số nhập vào từ bàn phím (kiểu chuỗi)

            //Console.WriteLine("         **************************************************");
            //Console.WriteLine("         *                                         			       *");
            //Console.WriteLine("         *   Chuong trinh tinh tong, hieu, tich, thuong  *");
            //Console.WriteLine("         *                                            		       *");
            //Console.WriteLine("         **************************************************");

            //Console.Write("\n Moi ban nhap so A: ");// "\n" dùng để xuống dòng
            //strA = Console.ReadLine(); // Nhận giá trị nhập vào từ bàn phím cho số A
            //Console.Write(" Moi ban nhap so B: ");
            //strB = Console.ReadLine(); // Nhận giá trị nhập vào từ bàn phím cho số B

            //A = int.Parse(strA); // Ép kiểu giá trị nhập vào từ kiễu chuỗi sang kiểu số nguyên, sử dụng phương thức Parse()
            //B = int.Parse(strB); // Tương tự

            //Tong = A + B;
            //Hieu = A - B;
            //Tich = A * B;
            //Thuong = (double)A / B; // Ép kiểu số A về số thập phân để phép chia cho ra số thập phân

            //Console.WriteLine(" Tong = " + Tong);
            //Console.WriteLine(" Hieu = " + Hieu);
            //Console.WriteLine(" Tich = " + Tich);
            //Console.WriteLine(" Thuong = " + Thuong);
            //Console.WriteLine("");

            Console.WriteLine("***CHUONG TRINH 6 REMAKE***");
            string strA, strB;
            int A, B;
            bool isTryParse1, isTryParse2;
            Console.Write("Nhap so A: ");
            strA = Console.ReadLine();
            Console.Write("Nhap so B: ");
            strB = Console.ReadLine();
            isTryParse1 = Int32.TryParse(strA, out A);
            isTryParse2 = Int32.TryParse(strB, out B);
            if ((isTryParse1 == false) || (isTryParse2 == false))
            {
                Console.WriteLine("Du lieu ban nhap khong thoa man");
                Console.WriteLine("Moi ban nhap lai");
                NhapSo();
            }
            else
            {
                int tong = A + B;
                int hieu = A - B;
                long tich = A * B;
                double thuong = (double)A / B;
                Console.WriteLine("Tong = " + tong);
                Console.WriteLine("Hieu = " + hieu);
                Console.WriteLine("Tich = " + tich);
                Console.WriteLine("Thuong = " + thuong);
            }

        }
        public static void NhapSo()
        {
            string strA, strB;
            int A, B;
            bool isTryParse1, isTryParse2;
            Console.Write("Nhap so A: ");
            strA = Console.ReadLine();
            Console.Write("Nhap so B: ");
            strB = Console.ReadLine();
            isTryParse1 = Int32.TryParse(strA, out A);
            isTryParse2 = Int32.TryParse(strB, out B);
            if ((isTryParse1 == false) || (isTryParse2 == false))
            {
                Console.WriteLine("Du lieu ban nhap khong thoa man");
                Console.WriteLine("Moi ban nhap lai");
                NhapSo();
            }
        }
    }
}
