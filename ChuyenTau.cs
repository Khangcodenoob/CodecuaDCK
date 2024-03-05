using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DetaiQUANLYVEXELUA
{
    internal class ChuyenTau 
    {
        private string line;
        public string NoiDi {  get; set; }
        public string Noiden {  get; set; }
        public DateTime ngayxuatphat { get; set; }
        public string Hangtau { get; set; }
        public string Soghe {  get; set; }
        public string Toa {  get; set; }
        public string MaTau {  get; set; }
        public string Loaitau { get; set; }

        public ChuyenTau() 
        {
           MaTau = Loaitau = Toa = Soghe = NoiDi = Noiden = Hangtau = "";
        }
   
        public ChuyenTau(string Matau, string loaitau, string toa,string soghe,string noiDi ,string noiden, DateTime Ngayxuatphat,  string hangtau)             
        {
            this.MaTau = Matau;
            this.Loaitau = loaitau;
            this.Toa = toa;
            this.Soghe = soghe;
            this.NoiDi = noiDi;
            this.Noiden = noiden;
            this.ngayxuatphat = Ngayxuatphat;
            this.Hangtau = hangtau;
        }
        public static List<ChuyenTau> ReadFromCSV(string filePath)
        {
            List<ChuyenTau> Chuyentaulist = new List<ChuyenTau>();
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string []values = line.Split(',');
                    string Matau = values[0];
                    string Loaitau = values[1];
                    string Toa = values[2];
                    string Soghe = values[3];   
                    string NoiDi = values[4];
                    string Noiden = values[5];
                    string dateString = values[6];
                    DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayxuatphat);
                    string Hangtau = values[7];
                    
                    ChuyenTau chuyenTau = new ChuyenTau(Matau, Loaitau, Toa, Soghe, NoiDi, Noiden, ngayxuatphat , Hangtau);
                    Chuyentaulist.Add(chuyenTau);
                }
            }
            return Chuyentaulist;
        }
        public static int SaveToFile(List<ChuyenTau> chuyentaulist, string fileName, bool insert = false)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    // Lines
                    foreach (var ns in chuyentaulist)
                    {
                        string line = "";
                        line += "," + ns.MaTau;
                        line += "," + ns.Loaitau;
                        line += "," + ns.Toa;
                        line += "," + ns.Soghe;
                        line += "," + ns.NoiDi;
                        line += "," + ns.Noiden;
                        line += "," + ns.ngayxuatphat;                      
                        line += "," + ns.Hangtau;
                        line = line.Remove(0,1);
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
