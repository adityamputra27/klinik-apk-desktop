using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikApp
{
    class GV
    {
        static String loadform;

        //Dokter

        static String nama_dokter;
        static String spesialis;
        static String tarif_dokter;

        //Obat
        static String obat_id;
        static String nama_obat;
        static String harga_obat;
        static String qty_obat;
        static String stock_obat;
        static String resep_obat;

        public static String LoadForm
        {
            get { return loadform; }
            set { loadform = value; }
        }

        public static String NamaDokter
        {
            get { return nama_dokter; }
            set { nama_dokter = value; }
        }
        public static String Spesialis
        {
            get { return spesialis; }
            set { spesialis = value; }
        }
        public static String Tarif_Dokter
        {
            get { return tarif_dokter; }
            set { tarif_dokter = value; }
        }
        public static String ObatID
        {
            get { return obat_id; }
            set { obat_id = value; }
        }
        public static String NamaObat
        {
            get { return nama_obat; }
            set { nama_obat = value; }
        }
        public static String HargaObat
        {
            get { return harga_obat; }
            set { harga_obat = value; }
        }
        public static String QTYObat
        {
            get { return qty_obat; }
            set { qty_obat = value; }
        }
        public static String StockObat
        {
            get { return stock_obat; }
            set { stock_obat = value; }
        }
        public static String ResepObat
        {
            get { return resep_obat; }
            set { resep_obat = value; }
        }
    }
}
