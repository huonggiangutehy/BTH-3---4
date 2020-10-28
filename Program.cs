using System;

namespace BTH3_4
{
    //Bai1TH3
    class Phanso
    {
        private int ts, ms;
        public Phanso()
        {
            ts = 0; ms = 1;
        }

        public Phanso(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: "); ts = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: "); ms = int.Parse(Console.ReadLine());
        }

        public void Hien()
        {
            if (ms == 1) Console.WriteLine("{0}", ts);
            else
                Console.WriteLine("{0}/{1}", ts, ms);
        }

        public int Ucln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }

        public Phanso ToiGian()
        {
            int uc = Ucln(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }

        public static Phanso operator +(Phanso t1, Phanso t2)
        {
            Phanso tong = new Phanso();
            tong.ts = t1.ts * t2.ms + t2.ts * t1.ms;
            tong.ms = t2.ms * t1.ms;
            tong.ToiGian();
            return tong;
        }

        public Phanso Cong(Phanso b)
        {
            Phanso tong = new Phanso();
            tong.ts = this.ts * b.ms + b.ts * this.ms;
            tong.ms = this.ms + b.ms;
            tong.ToiGian();
            return tong;
        }

        public static Phanso operator -(Phanso t1, Phanso t2)
        {
            Phanso tru = new Phanso();
            tru.ts = t1.ts * t2.ms - t2.ts * t1.ms;
            tru.ms = t2.ms * t1.ms;
            tru.ToiGian();
            return tru;
        }

        public Phanso Tru(Phanso b)
        {
            Phanso tru = new Phanso();
            tru.ts = this.ts * b.ms - b.ts * this.ms;
            tru.ms = this.ms + b.ms;
            tru.ToiGian();
            return tru;
        }
    }

    class App
    {
        static void Main1_3()
        {
            Phanso t1 = new Phanso();
            Phanso t2 = new Phanso();
            Console.WriteLine("Tong 2 phan so");
            Phanso tTong = t1.Cong(t2); tTong.Hien();
            Console.WriteLine("Hieu 2 phan so");
            Phanso tHieu = t1.Tru(t2); tHieu.Hien();


        }
    }


    //Bai3TH3

    class Time
    {
        private int gio, phut, giay;

        public Time()
        {
            gio = 0;
            phut = 0;
            giay = 0;
        }

        public Time(int gio, int phut, int giay)
        {
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
        }

        public int Gio
        {
            get
            {
                return gio;
            }
            set
            {
                gio = value;
            }
        }

        public int Phut
        {
            get
            {
                return phut;
            }
            set
            {
                phut = value;
            }
        }

        public int Giay
        {
            get
            {
                return giay;
            }
            set
            {
                giay = value;
            }
        }

        public void Hien()
        {
            Console.WriteLine("{0}:{1}:{2}", gio, phut, giay);
        }

        public int normalize(int gio, int phut, int giay)
        {
            phut = giay / 60;
            giay = giay % 60;
            gio = phut / 60;
            phut = phut % 60;
            gio = gio % 24;

            return gio; return phut; return giay;
        }

        public Time advance(int gio, int phut, int giay)
        {
            Time t = new Time();
            t.gio = this.gio + gio;
            t.phut = this.phut + phut;
            t.giay = this.giay + giay;

            t.phut = giay / 60;
            t.giay = giay % 60;
            t.gio = phut / 60;
            t.phut = phut % 60;
            t.gio = gio % 24;
            return t;
        }



    }


    //Bai4TH3
    class HocSinh
    {
        private string hoten;
        private double diemtoan, diemli, diemhoa;

        public HocSinh()
        {
            hoten = "";
            diemtoan = diemli = diemhoa = 0;
        }

        public HocSinh(string hoten, double diemtoan, double diemli, double diemhoa)
        {
            this.hoten = hoten;
            this.diemtoan = diemtoan;
            this.diemli = diemli;
            this.diemhoa = diemhoa;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemtoan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem li: ");
            diemli = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            diemhoa = double.Parse(Console.ReadLine());
        }

        public virtual void Hien()
        {
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Diem toan: " + diemtoan);
            Console.WriteLine("Diem li: " + diemli);
            Console.WriteLine("Diem hoa: " + diemhoa);
        }

    }

    class QL
    {
        private HocSinh[] dshs;
        private int shs;
        public void Nhap()
        {
            Console.Write("Nhap so hoc sinh: ");
            shs = int.Parse(Console.ReadLine());
            dshs = new HocSinh[shs];
            for (int i = 0; i < shs; i++)
            {
                dshs[i] = new HocSinh();
                dshs[i].Nhap();
            }
        }

        public void Hien()
        {
            for (int i = 0; i < shs; i++)
                dshs[i].Hien();
        }

    }

    class Ap
    {
        static void Main4_3(string[] args)
        {
            QL t = new QL();
            t.Nhap();
            t.Hien();
            Console.ReadLine();
        }
    }


    /// Bai5TH3
    class Vecto
    {
        private int n;
        private int[] v;
        public Vecto()
        {
            n = 2;
            v = new int[2];
        }

        public Vecto(int n)
        {
            this.n = n;
            v = new int[n];
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cua vecto");
            for (int i = 0; i < n; i++)
            {
                Console.Write("v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Hien()
        {
            Console.WriteLine("Thong tin cua vecto");
            for (int i = 0; i < n; i++)
                Console.Write("{0},", i);
        }

        public Vecto Tong(Vecto t2)
        {
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; i++)
                    t.v[i] = this.v[i] + t2.v[i];
                return t;
            }
            else return null;
        }

        public Vecto Hieu(Vecto t2)
        {
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; i++)
                    t.v[i] = this.v[i] - t2.v[i];
                return t;
            }
            else return null;
        }
    }

    class Appp
    {
        static void Main5_3(string[] args)
        {
            Console.WriteLine("Nhap thong tin cho vecto thu nhat");
            Vecto t1 = new Vecto(); t1.Nhap();
            Console.WriteLine("Nhap thong tin cho vecto thu hai");
            Vecto t2 = new Vecto(); t2.Nhap();

            Console.WriteLine("Tong hai vecto");
            Vecto tong = t1.Tong(t2);
            if (tong == null)
                Console.WriteLine("Khong tinh tong duoc vi 2 vecto co kich thuoc khong bang nhau");
            else
            {
                Console.WriteLine("Tong 2 vecto");
                tong.Hien();
            }

            Console.WriteLine("Hieu hai vecto");
            Vecto hieu = t1.Hieu(t2);
            if (hieu == null)
                Console.WriteLine("Khong tinh hieu duoc vi 2 vecto co kich thuoc khong bang nhau");
            else
            {
                Console.WriteLine("Hieu 2 vecto");
                hieu.Hien();
            }



            Console.ReadKey();
        }
    }


    //Bai1TH4
    class MaTran
    {
        private static int n;
        private int[,] a;

        public MaTran()
        {
            n = 2;
            a = new int[n, n];
        }

        public static int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value >= 2) n = value;
            }
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }

        public void Hien()
        {
            Console.WriteLine("Cac phan tu cua ma tran la");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();
            }
        }

        public MaTran Tong(MaTran t2)
        {
            MaTran t = new MaTran();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    t.a[i, j] = this.a[i, j] + t2.a[i, j];
            return t;

        }

        class QLMT
        {
            private MaTran[] ds;
            private int somt;

            public void Nhap()
            {
                Console.Write("Nhap cap ma tran: ");
                MaTran.N = int.Parse(Console.ReadLine());
                Console.Write("Nhap so ma tran: ");
                somt = int.Parse(Console.ReadLine());
                ds = new MaTran[somt];
                for (int i = 0; i < somt; i++)
                {
                    Console.WriteLine("Nhap ma tran thu " + i);
                    ds[i] = new MaTran();
                    ds[i].Nhap();
                }
            }

            public MaTran Tong()
            {
                MaTran t = new MaTran();
                for (int i = 0; i < somt; i++)
                    t = t.Tong(ds[i]);
                return t;
            }
        }
    }


    class Test
    {
        static void Main1_4(string[] args)
        {
            QLMT t = new QLMT();
            t.Nhap();
            Console.WriteLine("Ma tran tong");
            t.Tong().Hien();
            Console.ReadLine();
        }
    }


    //Bai2TH4
    class NhanVien
    {
        private string hoten, quequan;
        private double hesoluong;
        private static int luongcoban = 1050;

        public NhanVien()
        {
            hoten = quequan = "";
            hesoluong = 1.25;
        }

        public NhanVien(string hoten, string quequan, double hesoluong)
        {
            this.hoten = hoten;
            this.quequan = quequan;
            this.hesoluong = hesoluong;
        }

        public static int Luongcoban
        {
            get
            {
                return luongcoban;
            }
            set
            {
                if (value > 1050) luongcoban = value;
            }
        }

        public double Hesoluong
        {
            get
            {
                return hesoluong;
            }
        }

        public string Hoten
        {
            get
            {
                int n = hoten.LastIndexOf(" ");
                return hoten.Substring(n + 1) + " " + hoten.Substring(0, n);
            }
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            quequan = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            hesoluong = double.Parse(Console.ReadLine());
        }

        public virtual double TinhLuong()
        {
            return hesoluong * luongcoban;
        }
        public virtual void Hien()
        {
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Que quan: " + quequan);
            Console.WriteLine("He so luong: " + hesoluong);
        }

    }

    class QLNV
    {
        private NhanVien[] ds;
        private int snv;
        public void Nhap()
        {
            Console.Write("Nhap so nhan vien: ");
            snv = int.Parse(Console.ReadLine());
            ds = new NhanVien[snv];
            for (int i = 0; i < snv; i++)
            {
                ds[i] = new NhanVien();
                ds[i].Nhap();
            }
        }

        public void Hien()
        {
            for (int i = 0; i < snv; i++)
                ds[i].Hien();
        }

        public double MaxHsl()
        {
            double max = ds[0].Hesoluong;
            for (int i = 0; i < snv; i++)
                if (ds[i].Hesoluong > max) max = ds[i].Hesoluong;
            return max;
        }

        public void HienMaxHsl()
        {
            double max = MaxHsl();
            for (int i = 0; i < snv; i++)
                if (ds[i].Hesoluong == max) ds[i].Hien();
        }

        public void SapXep()
        {
            for (int i = 0; i < snv - 1; i++)
                for (int j = i + 1; j < snv; j++)
                    if (string.Compare(ds[i].Hoten, ds[j].Hoten) > 0)
                    {
                        NhanVien tg = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tg;
                    }
        }

    }

    class Tester
    {
        static void Main2_4(string[] args)
        {
            QL t = new QL();
            t.Nhap();
            t.Hien();
            Console.WriteLine("Nhan vien sau khi sap xep");
            t.SapXep();
            t.Hien();
            Console.ReadLine();
        }
    }


    /// /Bai4TH4
    class PhanTu
    {
        private double heso;
        private int somu;

        public PhanTu()
        {
            heso = somu = 0;
        }

        public PhanTu(double heso, int somu)
        {
            this.heso = heso;
            this.somu = somu;
        }

        public void Nhap()
        {
            Console.Write("Nhap he so: "); heso = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu: "); somu = int.Parse(Console.ReadLine());
        }

        public void Hien()
        {
            Console.Write("He so: " + heso);
            Console.Write("So mu: " + somu);
        }
    }

    class DaThuc
    {
        private int n;
        private PhanTu[] p;
        private double x;
        double[] hs = new double[50];

        public void Nhap()
        {
            Console.Write("Nhap he so: ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap cac he so");
            for (int i = 0; i <= n; i++)
            {
                Console.Write("hs[{0}] = ", i);
                hs[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public static double SoMu(double x, int n)
        {
            if (n == 0) return 1;
            else
                return x * SoMu(x, n - 1);
        }

        public void Hien()
        {
            Console.Write("Gia tri x :" + x);
            Console.WriteLine("Cac he so cua da thuc:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write("hs[{0}] = " + i);
            }

        }

        public double Gtdt()
        {
            double p = 0;
            for (int i = 0; i <= n; i++)
                p = p + hs[i] * SoMu(x, n - i);
            return p;
        }

        class App
        {
            static void Main4_4(string[] args)
            {
                DaThuc p = new DaThuc();
                p.Nhap();
                Console.WriteLine("Gia tri cua da thuc = {0}");
            }
        }
    }

}
