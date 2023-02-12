using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    internal class Test5
    {
        //Bài này về cấu trúc rẽ nhánh if else
        public static void Run()
        {
            //Muốn chạy chương trình này thì bỏ comment
            //Console.WriteLine("***CHUONG TRINH 1***");
            //string K = "Kteam";
            //if (K == "Kteam")// Biểu thức điều kiện sử dụng toán tử == đề so sánh xem giá trị biến K có bằng “Kteam” hay không. Nếu bằng trả thì trả về true ngược lại thì trả về false.
            //Console.WriteLine("Free Education"); // In ra màn hình chữ “Free Education” nếu biểu thức trên đúng.
            //Console.WriteLine("");

            Console.WriteLine("***CHUONG TRINH 2***");
            string K = "Kteam";

            if (K == "Kteam") // Nếu giá trị K bằng “Kteam” thì
                Console.WriteLine("Free Education"); // In ra màn hình “Free Education”
            else // Ngược lại thì
                Console.WriteLine("Connecting to HowKteam. . ."); // In ra màn hình “Connecting to HowKteam. . .”
            Console.WriteLine("");

            //Hình như bài này sai
            Console.WriteLine("***CHUONG TRINH 3***");
            string strA, strB;
            int A, B;
            double Nghiem;

            Console.WriteLine("         ***************************************************");
            Console.WriteLine("         *                                        			        *");
            Console.WriteLine("         *    Chuong trinh giai phuong trinh Ax + B = 0 *");
            Console.WriteLine("         *                                                 		        *");
            Console.WriteLine("         ***************************************************");

            Console.Write(" Moi nhap so A: ");
            strA = Console.ReadLine();
            Console.Write(" Moi nhap so B: ");
            strB = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false) // kiểm tra người dùng có thực sự nhập số nguyên vào hay không. Nếu ép kiểu thành công sẽ trả về true, ngược lại trả về false
            {
                Console.WriteLine(" Du lieu nhap sai !");
                return; // Lệnh này tạm hiểu là dừng và thoát chương trình mà không thực hiện những câu lệnh sau nó nữa. Sẽ được tìm hiểu chi tiết trong bài 16 Hàm
            }
            else
            {
                Console.WriteLine("\n Phuong trinh cua ban vua nhap la: {0}x + {1} = 0", A, B);

                if (A == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem !");
                }
                else if (B == 0)
                {
                    Console.WriteLine("\n Phuong trinh co nghiem x = 0");
                }
                else
                {
                    Nghiem = (double)-B / A; // Ép kiểu để cho ra kết quả chính xác
                    Console.WriteLine("\n Phuong trinh co nghiem x = {0}", Nghiem);
                }
            }
            Console.WriteLine("");

            //Bài toán tìm tuổi theo năm sinh theo năm 2023
            //Console.WriteLine("***CHUONG TRINH 4***");
            //string strNamSinh;
            //int namSinh;
            //bool isTryParse;
            //int tuoi;
            //Console.Write("Nhap nam sinh cua ban: ");
            //strNamSinh = Console.ReadLine();
            //isTryParse = Int32.TryParse(strNamSinh, out namSinh);
            //if (isTryParse == false)
            //{
            //    Console.WriteLine("Du lieu nhap vao khong dung");
            //    Console.WriteLine("Moi ban nhap lai");
            //    NhapNamSinh();
            //}
            //else if ((namSinh > 2023) && (isTryParse == true))
            //{
            //    Console.WriteLine("Du lieu nhap vao khong dung");
            //    Console.WriteLine("Nam nay la nam 2023");
            //    Console.WriteLine("Moi ban nhap lai");
            //    NhapNamSinh();
            //}
            //else
            //{
            //    tuoi = 2023 - namSinh;
            //    Console.WriteLine($"So tuoi cua ban la: {tuoi}");
            //}
            //Console.WriteLine("");

            //Update chức năng chương trình 4
            Console.WriteLine("***CHUONG TRINH 5***");
            string strNamSinh;
            int namSinh;
            bool isTryParse;
            int tuoi;
            Console.Write("Nhap nam sinh cua ban: ");
            strNamSinh = Console.ReadLine();
            isTryParse = Int32.TryParse(strNamSinh, out namSinh);
            if (isTryParse == false)
            {
                Console.WriteLine("Du lieu nhap vao khong dung");
                Console.WriteLine("Moi ban nhap lai");
                NhapNamSinh();
            }
            else if ((namSinh > 2023) && (isTryParse == true))
            {
                Console.WriteLine("Du lieu nhap vao khong dung");
                Console.WriteLine("Nam nay la nam 2023");
                Console.WriteLine("Moi ban nhap lai");
                NhapNamSinh();
            }
            else
            {
                tuoi = 2023 - namSinh;
                Console.WriteLine($"So tuoi cua ban la: {tuoi}");
                if (tuoi < 16)
                {
                    Console.WriteLine($"Ban {tuoi} tuoi, tuoi vi thanh nien");
                }
                else if (tuoi >= 18)
                {
                    Console.WriteLine($"Ban {tuoi} tuoi, gia roi");
                }
                else
                {
                    Console.WriteLine($"Ban {tuoi} tuoi, tuoi truong thanh");
                }
            }
            Console.WriteLine("");

            //Trò chơi kéo búa bao
            Console.WriteLine("***CHUONG TRINH 6***");
            string strPlayerChoose;
            int playerChoose;
            bool isTryParse1;
            int botChoose;
            Console.WriteLine("Chao mung ban den tro choi Keo-Bua-Bao");
            Console.WriteLine("Moi ban lua chon:");
            Console.WriteLine("1: Keo");
            Console.WriteLine("2: Bua");
            Console.WriteLine("3: Bao");
            strPlayerChoose = Console.ReadLine();
            isTryParse1 = Int32.TryParse(strPlayerChoose, out playerChoose);
            if (isTryParse1 == false)
            {
                Console.WriteLine("Lua chon khong hop le");
                Console.WriteLine("Moi ban chon lai");
                PlayerChose();
            }
            else if ((isTryParse1 == true) && (playerChoose == 1))
            {
                Console.WriteLine("Ban chon keo");
            }
            else if ((isTryParse1 == true) && (playerChoose == 2))
            {
                Console.WriteLine("Ban chon bua");
            }
            else if ((isTryParse1 == true) && (playerChoose == 3))
            {
                Console.WriteLine("Ban chon bao");
            }
            Random rd = new Random();
            botChoose = rd.Next(1,3);
            if (((botChoose == 1)&&(playerChoose == 1))||((playerChoose == 2)&&(botChoose ==2))||((playerChoose == 3)&&(botChoose ==3)))
            {
                Console.WriteLine("Ban hoa voi may");
            }
            else if ((playerChoose == 1)&&(botChoose == 2)) 
            {
                Console.WriteLine("Ban da thua may");
            }
            else if ((playerChoose == 2) && (botChoose == 3))
            {
                Console.WriteLine("Ban da thua may");
            }
            else if ((playerChoose == 3) && (botChoose == 1))
            {
                Console.WriteLine("Ban da thua may");
            }
            else if ((playerChoose == 1) && (botChoose == 3))
            {
                Console.WriteLine("Ban da thang may");
            }
            else if ((playerChoose == 2) && (botChoose == 1))
            {
                Console.WriteLine("Ban da thang may");
            }
            else if ((playerChoose == 3) && (botChoose == 2))
            {
                Console.WriteLine("Ban da thang may");
            }
        }
        public static void NhapNamSinh()
        {
            string strNamSinh;
            int namSinh;
            bool isTryParse;
            int tuoi;
            Console.Write("Nhap nam sinh cua ban: ");
            strNamSinh = Console.ReadLine();
            isTryParse = Int32.TryParse(strNamSinh, out namSinh);
            if (isTryParse == false)
            {
                Console.WriteLine("Du lieu nhap vao khong dung");
                Console.WriteLine("Moi ban nhap lai");
                NhapNamSinh();
            }
            else if ((namSinh > 2023) && (isTryParse == true))
            {
                Console.WriteLine("Du lieu nhap vao khong dung");
                Console.WriteLine("Nam nay la nam 2023");
                Console.WriteLine("Moi ban nhap lai");
                NhapNamSinh();
            }
            else
            {
                tuoi = 2023 - namSinh;
                Console.WriteLine($"So tuoi cua ban la: {tuoi}");
                if (tuoi < 16)
                {
                    Console.WriteLine($"Ban {tuoi} tuoi, tuoi vi thanh nien");
                }
                else if (tuoi >= 18)
                {
                    Console.WriteLine($"Ban {tuoi} tuoi, gia roi");
                }
                else
                {
                    Console.WriteLine($"Ban {tuoi} tuoi, tuoi truong thanh");
                }
            }
        }

        public static void PlayerChose()
        {
            string strPlayerChoose;
            int playerChoose;
            bool isTryParse1;
            Console.WriteLine("Chao mung ban den tro choi Keo-Bua-Bao");
            Console.WriteLine("Moi ban lua chon:");
            Console.WriteLine("1: Keo");
            Console.WriteLine("2: Bua");
            Console.WriteLine("3: Bao");
            strPlayerChoose = Console.ReadLine();
            isTryParse1 = Int32.TryParse(strPlayerChoose, out playerChoose);
            if (isTryParse1 == false)
            {
                Console.WriteLine("Lua chon khong hop le");
                Console.WriteLine("Moi ban chon lai");
                PlayerChose();
            }
            else if ((isTryParse1 == true) && (playerChoose == 1))
            {
                Console.WriteLine("Ban chon keo");
            }
            else if ((isTryParse1 == true) && (playerChoose == 2))
            {
                Console.WriteLine("Ban chon bua");
            }
            else if ((isTryParse1 == true) && (playerChoose == 3))
            {
                Console.WriteLine("Ban chon bao");
            }
        }
    }
}
