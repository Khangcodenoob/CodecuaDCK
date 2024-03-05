using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DetaiQUANLYVEXELUA
{
    internal class Khachhang
    {
        private string line;
        public string MaKH { get; set; }
        public string Ten { get; set; }
        public string CCCD { get; set; }
        public string Gioitinh { get; set; }
        public string Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string SĐT { get; set; }
        public string Email { get; set; }
        public string Quequan { get; set; }
        public string Quoctich { get; set; }


        public Khachhang()
        {
            MaKH = "";
            Ten = "";
            Diachi = "";
            SĐT = "";
            Email = "";
            CCCD = Gioitinh = Ngaysinh = Quequan = Quoctich = "";
        }
        public Khachhang(string maKH, string Ten, string cccd, string gioitinh, string ngaysinh, string quequan, string quoctich, string Diachi, string SĐT, string Email)
        {
            this.MaKH = maKH;
            this.Ten = Ten;
            this.CCCD = cccd;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Diachi = Diachi;
            this.SĐT = SĐT;
            this.Email = Email;
            this.Quequan = quequan;
            this.Quoctich = quoctich;
        }
        public static List<Khachhang> ReadFromCSV(string filePath)
        {
            List<Khachhang> khachhanglist = new List<Khachhang>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    string maKH = values[0];
                    string Ten = values[1];
                    string CCCD = values[2];
                    string Gioitinh = values[3];
                    string Ngaysinh = values[4];
                    string Diachi = values[5];
                    string SĐT = values[6];
                    string Email = values[7];
                    string Quequan = values[8];
                    string Quoctich = values[9];
                    
                    Khachhang khachhang = new Khachhang(maKH , Ten , CCCD , Gioitinh , Ngaysinh, Diachi , SĐT, Email , Quequan , Quoctich );
                    khachhanglist.Add(khachhang);

                }
            }
            return khachhanglist;
        }
        public static int SaveToFile(List<Khachhang> khachhanglist, string fileName, bool insert = false)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    // Lines
                    foreach (var ns in khachhanglist)
                    {
                        string line = "";
                        line += "," + ns.MaKH;
                        line += "," + ns.Ten;
                        line += "," + ns.CCCD;
                        line += "," + ns.Gioitinh;
                        line += "," + ns.Ngaysinh;
                        line += "," + ns.Diachi;
                        line += "," + ns.SĐT;
                        line += "," + ns.Email;
                        line += "," + ns.Quequan;
                        line += "," + ns.Quoctich;
                      line = line.Remove(0, 1);
                        sw.Write(line);
                        sw.Write(sw.NewLine);
                    }
                }

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
