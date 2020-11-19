using Entity.Concrete;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
namespace denemeler
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\lenovo\Downloads\RAPOR_CKS_DilekcesiOlupVefatEdenKisiler.xlsx";
            DataSet ds=StaticClass.ExcelOperation.ExcelOku(path);
            foreach (var item in ds.Tables[1].Rows)
            {
                sınıf s = new sınıf();
                s = (sınıf)item;
                Console.WriteLine($"{s.isim} {s.tarih} {s.tc}");
            }
            
            Console.WriteLine("bitti");
            Console.ReadLine();
        }
    }
    class sınıf
    {
        public string isim { get; set; }
        public string tc { get; set; }
        public string tarih { get; set; }
    }
}
