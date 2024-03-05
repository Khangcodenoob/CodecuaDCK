using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetaiQUANLYVEXELUA
{
    internal class Datve 
    {
        private string line;
        // Các thuộc tính trong class Datve
        public string Mave { get; set; }
        public string MaKH { get; set; }
        public string MaTau { get; set; }
        public string Loaive { get; set; }
        public string Noiden { get; set; }
        public string NoiDi { get; set; }
        public DateTime Ngayxuatphat { get; set; }
        public double Tien { get; set; }

        // Constructor ko có tham số  
        public Datve()
        {
            Mave = MaTau = Loaive = MaKH = Noiden = NoiDi = "";
            Tien = 0;
        }
        // Constructor có tham số 
        public Datve(string mave, string maKH, string matau, string loaive,string noiden, string noidi ,DateTime ngayxuatphat, double tien)
        {
            this.Mave = mave;
            this.MaKH = maKH;       
            this.MaTau = matau;
            this.Loaive = loaive;
            this.Noiden = noiden;
            this.NoiDi = noidi;
            this.Ngayxuatphat = ngayxuatphat;
            this.Tien = tien;

        }

        //public Datve(string line)
        //{
        //    this.line = line;
        //}
        public static List<Datve> ReadFormCSV(string filePath)
        {
            // Tạo một danh sách để lưu trữ các đối tượng Datve
            List<Datve> datvelist = new List<Datve>();

            // Mở tệp CSV đã chỉ định để đọc file
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Đọc tệp theo dòng cho đến khi đọc hết tệp
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    // Tách dòng thành một mảng các giá trị bằng cách sử dụng dấu phẩy làm dấu phân cách
                    string[] values = line.Split(',');

                    // Trích xuất giá trị từ mảng và gán chúng vào các biến
                    string Mave = values[0];
                    string MaKH = values[1];                
                    string Matau = values[2];
                    string Loaive = values[3];
                    string Noiden = values[4];
                    string Noidi = values[5];
                    string datestring = values[6];
                    DateTime.TryParseExact(datestring, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayxuatphat);
                    string Tien = Convert.ToString(values[7]);

                    // Tạo một đối tượng Datve mới sử dụng các giá trị trích xuất và thêm vào danh sách
                    Datve datve = new Datve(Mave, MaKH, Matau, Loaive, Noiden, Noidi, ngayxuatphat, Convert.ToDouble(Tien));
                    datvelist.Add(datve);
                }
            }
            return datvelist;
        }

        public static int SaveToFile(List<Datve> datvelist,string fileName, bool insert = false)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    // Lines
                    //Duyệt qua đối tượng nằm trong danh sách datve 
                    foreach (var ns in datvelist)
                    {
                        string line = "";
                        // Thêm các thuộc tính của đối tượng Datve vào dòng
                        line += "," + ns.Mave;
                        line += "," + ns.MaKH;              
                        line += "," + ns.MaTau;
                        line += "," + ns.Loaive;
                        line += "," + ns.Noiden;
                        line += "," + ns.NoiDi;
                        line += "," + ns.Ngayxuatphat;
                        line += "," + ns.Tien;
                        line = line.Remove(0, 1);
                        sw.Write(line);
                        sw.Write(sw.NewLine);
                    }
                }
                // Trả về 1 để thể hiện thành công
                return 1;
            }
            catch
            {
                // Trả về 0 để thể hiện lỗi khi có ngoại lệ xảy ra
                return 0;
            }
        }
    }
}

