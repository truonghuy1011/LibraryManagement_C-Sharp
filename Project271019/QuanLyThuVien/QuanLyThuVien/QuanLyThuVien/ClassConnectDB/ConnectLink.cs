using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ClassConnectDB
{
    class ConnectLink
    {
        private string userDB;
        private string passDB;
        private string ipAdressDB;
        private string nameDB;
        
        public ConnectLink()
        {
            GetFile();
        }

        public string GetConnectLink()
        {
            return "Server=" + ipAdressDB + ",1433" + ";" + "Database=" + this.nameDB + ";" + "User Id=" + this.userDB +
                ";" + "Password=" + this.passDB + ";";
        }

        private void GetFile()
        {
            string reLine = null;
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader("ServerLink"))
                {
                    string[] line = new string[5];
                    int i = 0;
                    while ((line[i] = sr.ReadLine()) != null)
                    {                        
                        i++;
                    }

                    this.ipAdressDB = line[0];
                    this.userDB = line[1];
                    this.passDB = line[2];
                    this.nameDB = line[3];

                    Console.WriteLine(this.userDB);
                    Console.WriteLine(this.passDB);
                    Console.WriteLine(this.ipAdressDB);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Khong the doc du lieu tu file da cho: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
