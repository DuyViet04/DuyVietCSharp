using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    internal class Exam2
    {
        //Đây là bài về kiểu dữ liệu
        //Các chương trình bên dưới đều được copy trên web
        public static void Run()
        {
            //Đây là chương trình về gán biến
            Console.WriteLine("***CHUONG TRINH 1***");
            //Kiểu số nguyên
            //byte bienbyte = 10;
            //short bienshort = 10;
            //int bienint = 10;
            //long bienlong = 10;

            // Kiểu số thực
            float BienFloat = 10.9f; // Giá trị của biến kiểu float phải có hậu tố f hoặc F. 
            double BienDouble = 10.9; // Giá trị của biến kiểu double không cần hậu tố.
            decimal BienDecimal = 10.9m; // Giá trị của biến kiểu decimal phải có hậu tố m.

            // Kiểu ký tự và kiểu chuỗi
            char BienChar = 'K'; // Giá trị của biến kiểu ký tự nằm trong cặp dấu '' (nháy đơn).
            string BienString = "Kteam"; // Giá trị của biến kiểu chuỗi nằm trong cặp dấu "" (nháy kép).

            Console.ReadKey();//Dòng này để tạm dừng chương trình cho đến khi ấn 1 nút nào đó từ bàn phím
            Console.WriteLine("");
            //Đây là chương trình về thao tác với biến
            Console.WriteLine("***CHUONG TRINH 2");
            // Kiểu số nguyên
            //Muốn dùng biến bên dưới thì comment biến bên trên
            byte BienByte = 3;
            short BienShort = 9;
            int BienInt = 10;
            long BienLong = 0;

            BienLong = BienByte; // BienLong có kiểu dữ liệu lớn hơn BienByte nên giá trị BienByte có thể gán qua cho BienLong
            Console.WriteLine(" BienLong = " + BienLong);

            BienLong = BienInt; // tương tự như trên
            Console.WriteLine(" BienLong = {0}", BienLong);

            BienShort = BienByte; // tương tự như trên
            Console.WriteLine(" BienShort = " + BienShort);

            BienInt = BienShort; // tương tự như trên
            Console.WriteLine(" BienInt = " + BienInt);

            Console.ReadKey();
            Console.WriteLine("");
            //Đây là chương trình về lỗi hay gặp
            //Nó sẽ không chạy được
            //Muốn chạy 2 chương trình trên thì comment nó lại
            //Lệnh comment nhiều dòng có thể tra

            //Console.WriteLine("***CHUONG TRINH 3***");
            //int a;
            //Console.WriteLine(" a = " + a); // Lỗi vì biến a không thể sử dụng khi chưa có giá trị.

            //int b = 10.9; // Lỗi vì b là biến kiểu số nguyên nên không thể nhận giá trị ngoài số nguyên.

            //byte c = 1093; // Lỗi vì c là biến kiểu byte mà kiểu byte có miền giá trị từ -128 đến 127 nên không thể nhận giá ngoài vùng này được.

            //string d = 'K'; // Lỗi vì không thể gán giá trị ký tự vào biến kiểu chuỗi được mặc dù chuỗi có thể hiểu là tập hợp nhiều ký tự. Có thể sửa bẳng cặp dấu "" thay vì ''. 

            //long e = null; // Lỗi vì không thể gán null cho biến kiểu long, int, byte, . . .
            //long? f = null; // Cách khắc phục là thêm dấu ? vào sau kiểu dữ liệu. Lúc này kiểu dữ liệu của f là long?

            //int g = 10;
            //byte h = g; // Lỗi vì giá trị của biến có kiểu dữ liệu lớn hơn không thể gán cho biến có kiểu dữ liệu nhỏ hơn mặc dù trong trường hợp này ta thấy số 10 đều có thể gán cho 2 biến.

            //string k = "Kteam";
            //Console.WriteLine(" k = " + K); // Lỗi vì phía trên khai báo biến k còn khi sử dụng là biến K (C# có phân biệt chữ hoa, thường cần lưu ý để tránh gặp lỗi)

            //Console.ReadKey();
        }
    }
}
