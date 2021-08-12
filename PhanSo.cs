using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class PhanSo
    {
        int TuSo;
        int MauSo;

        public static int UocChungLonNhat(int a, int b) // Tìm ra ước chung sai rồi
        {
            if (a%b == 0)
            {
                return b;
            }
            else
            {
                return UocChungLonNhat(b, a%b);
            }
        }
        public void nhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
        }
        
        public void xuatPhanSo()
        {
            // Console.WriteLine("Phân số của bạn là:" );
            Console.WriteLine(TuSo);
            if (TuSo > 9 || MauSo > 9)
            {
                Console.WriteLine("---");
            }
            else
            {
                Console.WriteLine("--");
            }
            Console.WriteLine(MauSo);
        }
        public void xuatPhanSo(int a, int b)
        {
            Console.WriteLine(a);
            if (a > 9 || b > 9)
            {
                Console.WriteLine("---");
            }
            else
            {
                Console.WriteLine("--");
            }
            Console.WriteLine(b);
        }
        public int LayTuSo()
        {
            return TuSo;
        }
        public int LayMauSo()
        {
            return MauSo;
        }
        public void GanTuSo(int a) 
        {
            TuSo = a;
        }
        public void GanMauSo(int a)
        {
            MauSo = a;
        }
        public void NghichDao()
        {
            int TuSoDao = MauSo;
            int MauSoDao = TuSo;
            Console.WriteLine("Phân số nghịch đảo là: ");
            Console.WriteLine(TuSoDao);
            Console.WriteLine("--");
            Console.WriteLine(MauSoDao);
        }
        
        public void RutGon()
        {
            int UocChungLaGi;
            if (TuSo > MauSo)
            {
                UocChungLaGi = UocChungLonNhat(TuSo, MauSo);
            }
            else
            {
                UocChungLaGi = UocChungLonNhat(MauSo, TuSo); 
            }
            int TuSoSauRutGon = TuSo / UocChungLaGi;

            int MauSoSauRutGon = MauSo / UocChungLaGi;

            xuatPhanSo(TuSoSauRutGon, MauSoSauRutGon);
        }
        public int mMauSoChung(PhanSo ps)
        {
            return this.LayMauSo() * ps.LayMauSo();
        }
        public void QuyDongMau(PhanSo ps)
        {
            int MauSoChung = this.mMauSoChung(ps);
            
            PhanSo ps1m = new PhanSo();
            PhanSo ps2m = new PhanSo();
            ps2m.GanMauSo(MauSoChung);
            ps1m.GanMauSo(MauSoChung);
            ps1m.GanTuSo(this.LayTuSo() * ps.LayMauSo());
            ps2m.GanTuSo(ps.LayTuSo() * this.LayMauSo());
            ps1m.xuatPhanSo();
            ps2m.xuatPhanSo();
        }
        
        public void CongPhanSo(PhanSo ps)
        {
            int TuSoTong = this.LayTuSo()*ps.LayMauSo() + ps.LayTuSo()*this.LayMauSo();
            int MauSoTong = this.mMauSoChung(ps);
            xuatPhanSo(TuSoTong, MauSoTong);
        }
        public void TruPhanSo(PhanSo ps)
        {
            int TuSoHieu = this.LayTuSo() * ps.LayMauSo() - ps.LayTuSo() * this.LayMauSo();
            int MauSoHieu = this.mMauSoChung(ps);
            xuatPhanSo(TuSoHieu, MauSoHieu);
        }
        public void NhanPhanSo(PhanSo ps)
        {
            int TuSoTich = this.LayTuSo() * ps.LayTuSo();
            int MauSoTich = this.LayMauSo() * ps.LayMauSo();
            xuatPhanSo(TuSoTich, MauSoTich);
        }
        public void ChiaPhanSo(PhanSo ps)
        {
            int TuSoThuong = this.LayTuSo() * ps.LayMauSo();
            int MauSoThuong = ps.LayTuSo() * this.LayMauSo();
            xuatPhanSo(TuSoThuong, MauSoThuong);
        }
        public void SoSanhPhanSo(PhanSo ps)
        {
            if (this.LayTuSo() / this.LayMauSo() > ps.LayTuSo() / ps.LayMauSo())
            {
                Console.WriteLine("Phân số thứ nhất lớn hơn Phân số thứ hai");
            }
            else
            {
                Console.WriteLine("Phân số thứ hai lớn hơn Phân số thừ nhất");
            }
        }
        public void XoaPhanSo(PhanSo ps)
        {
            this.GanTuSo(0);
            this.GanMauSo(0);
            ps.GanTuSo(0);
            ps.GanMauSo(0);
        }
    }
}
