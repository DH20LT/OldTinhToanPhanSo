using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class Program
    {
        static bool YesNo() // Lựa chọn Yes hoặc No thông qua việc đưa vào giá trị 1 hoặc khác 1
        {
            if (Console.ReadLine() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void DiTiep()
        {
            Console.WriteLine("Bạn có muốn tiếp tục dùng chức năng khác? (Enter để tiếp tục)");
            // bool TiepTuc = YesNo();
            
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }
        
        static void Main(string[] args)
        {
            int HienPhanSo = 1;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Title = "Phần mềm Tính toán Phân số";

            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            int VongLap = 1;
            while (VongLap < 100)
            {
                Console.WriteLine("Máy tình Phân số Đơn Giản ({0})",VongLap);
                Console.WriteLine("   1. Nhập phân số của bạn"); //DONE
                Console.WriteLine("   2. Hiện các phân số mà tôi vừa nhập"); //DONE
                Console.WriteLine("   3. Phân Số nghịch đảo");
                Console.WriteLine("   4. Rút gọn phân số");
                Console.WriteLine("   5. Quy đồng mẫu hai phân số");
                Console.WriteLine("   6. Cộng hai phân số");
                Console.WriteLine("   7. Trừ hai phân số");
                Console.WriteLine("   8. Nhân hai phân số");
                Console.WriteLine("   9. Chia hai phân số");
                Console.WriteLine("   10. So sanh hai phân số");
                Console.WriteLine("   11. Xóa tất cả phân số!!!");
                Console.Write("Chọn chức năng bạn muốn sử dụng..! --> ");
                int ChucNang = int.Parse(Console.ReadLine());
                switch(ChucNang){
                    case 1: //Nhập phân số của bạn - DONE
                        {
                            if (VongLap > 1 && ps1.LayMauSo() != 0)
                            {
                                Console.WriteLine("Bạn muốn nhập phân số một hay hai?");
                                Console.WriteLine("   Phân số .1.");
                                Console.WriteLine("   Phân số .2.");
                                int ChonPhanSo = int.Parse(Console.ReadLine());
                                switch (ChonPhanSo)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Nhap phân số 1:");
                                            ps1.nhapPhanSo();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Nhap phân số 2:");
                                            ps2.nhapPhanSo();
                                            break;
                                        }
                                    default:
                                        Console.WriteLine("Làm gì có phần số nào khác ngoài thứ hai và thứ nhât trong chương trình này chứ");
                                        break;
                                }
                            }
                            else
                            {
                                ps1.nhapPhanSo();
                                Console.Write("Bạn có muốn nhập phân số thứ hai không? (Enter để đồng ý) --> ");
                                if (Console.ReadKey().Key == ConsoleKey.Enter)
                                {
                                    ps2.nhapPhanSo();
                                }
                                else HienPhanSo = 0;
                            }
                            Console.Clear();
                            break;
                        }
                    case 2: //Hiện các phân số mà tôi vừa nhập - DONE
                        {
                            Console.WriteLine("Phân số thứ nhất là");
                            ps1.xuatPhanSo();
                            Console.WriteLine("------------");
                            if (HienPhanSo == 0)
                            {
                                Console.WriteLine("Bạn chưa nhập phân số thứ hai..!");
                            }
                            else
                            {
                                Console.WriteLine("Phân số thứ hai là");
                                ps2.xuatPhanSo();
                            }
                            DiTiep();
                            break;
                        }
                    case 3: // Phân Số nghịch đảo - DONE
                        {
                            ps1.NghichDao();
                            ps2.NghichDao();
                            break;
                        }
                    case 4: // Rút gọn phân số - DONE
                        { 
                            ps1.RutGon();
                            if (ps2.LayMauSo() != 0)
                            {
                                ps2.RutGon();
                            }
                            else
                            {
                                Console.WriteLine("Chưa có phân số hai..!");
                            }
                            break;
                        }
                    case 5: // Quy đồng mẩu hai phân số - DONE
                        {
                            ps1.QuyDongMau(ps2);
                            break;
                        }
                    case 6: // Cộng hai phân số - DONE
                        {
                            ps1.CongPhanSo(ps2);
                            break;
                        }
                    case 7: // Trừ hai phân số - DONE
                        {
                            ps1.TruPhanSo(ps2);
                            break;
                        }
                    case 8: // Nhân hai phân số - DONE
                        {
                            ps1.NhanPhanSo(ps2);
                            break;
                        }
                    case 9: // Chia hai phân số - DONE
                        {
                            ps1.ChiaPhanSo(ps2);
                            break;
                        }
                    case 10: // So sanh hai phân số - DONE
                        {
                            ps1.SoSanhPhanSo(ps2);
                            break;
                        }
                    case 11: // Xóa tất cả phân số đã nhập - DONE
                        {
                            ps1.XoaPhanSo(ps2);
                            break;
                        }
                    default:
                        Console.Write("Bạn chọn mã chức năng không tồn tại..!");
                        break;
                }
                VongLap++;
            }
            Console.ReadKey();
        }
    }
}
