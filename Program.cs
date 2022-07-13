using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<string> daftarPenjualan = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return ;

                    default:

                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu aplikasi");
            Console.WriteLine("1.Tambah penjualan");
            Console.WriteLine("2.Tampilkan penjualan");
            Console.WriteLine("3.Keluar");


            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Penjualan penjualan  = new Penjualan();
            Console.WriteLine("Tambah data penjualan\n");
            Console.WriteLine();

            Console.Write("Nota\n");
            penjualan.Nota = Console.ReadLine();
            Console.Write("Tanggal\n");
            penjualan.Tanggal = Console.ReadLine();
            Console.Write("Customer\n");
            penjualan.Pelanggan = Console.ReadLine();
            Console.Write("Jenis [T/K]\n");
            penjualan.Jenis = Console.ReadLine();
            Console.Write("Total Nota: \n");
            penjualan.JumlahNota = double.Parse(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            int nota = 0;
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("Data Penjualan");
            foreach (Penjualan penjualan in daftarPenjualan)
            {

                nota++;
                string jenis;
                if (penjualan.Jenis == "T")
                {
                    jenis = "Tunai";
                }
                else if (penjualan.Jenis == "K")
                {
                    jenis = "Kredit";
                }
                else
                {
                    jenis = "Jenis tidak diketahui!";
                }
                Console.WriteLine( nota + ". " + penjualan.Nota + ", " + penjualan.Tanggal + ", " + penjualan.Pelanggan + ", " + jenis + ", " + penjualan.JumlahNota);
            }
            if (nota < 1)
            {
                Console.WriteLine("Data Penjualan Kosong");
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}