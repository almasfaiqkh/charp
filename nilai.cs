using System;
using System.Threading;

namespace Nilai
{
    class Program
    {
        static void Main()
        {
            string username, password;
            Console.Clear();
            const string USERNAME = "Admin";
            const string PASSWORD = "admin";

            for (; ; )
            {
                Console.WriteLine("Masukkan username dan password");
                Console.Write("Username: ");
                username = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();
                Console.WriteLine();

                if ((username == USERNAME) && (password == PASSWORD))
                {
                    break;
                }
            }

            Console.Write("\nMemuat"); Thread.Sleep(1000);
            Console.Write("."); Thread.Sleep(1000);
            Console.Write("."); Thread.Sleep(1000);
            Console.Write("."); Thread.Sleep(2000);
            Console.WriteLine("\nProses Selesai ^_^");
            Console.WriteLine();

            Console.WriteLine("Selamat Datang " + username + " di Project Penilaian Raport"); Thread.Sleep(2000);

            Raport bk = new Raport();
            int i = 1;
            while (i <= 2)
            {
                int pilih;
                Console.WriteLine("\n\tMenu Penilaian Raport\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\t1. Tambah Siswa & Nilai Mapel");
                Console.WriteLine("\t2. Cetak Siswa & Nilai");
                Console.WriteLine("\t0. Exit\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("Pilih : ");
                pilih = int.Parse(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        {
                            bk.Tambah();
                            break;
                        }
                    case 2:
                        {
                            bk.Tampil();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Sampai Jumpa Lagi ^_^ ");
                            Console.Clear();
                            Environment.Exit(1);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Silahkan Pilih Kode yang ada");
                            break;
                        }
                }
                Console.ReadKey();
            }
        }
    }
}

namespace Nilai
{
    class Raport
    {
        public string[] jurusan, nama, id, nilai, nilai1,
                        nilai2, nilai3, nilai4;
        int c;
        public void Tambah()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("5 Mapel Produktif dengan Jumlah Siswa yang akan di input : ");
            c = int.Parse(Console.ReadLine());

            id = new string[255];
            nama = new string[255];
            jurusan = new string[255];
            nilai = new string[255];
            nilai1 = new string[255];
            nilai2 = new string[255];
            nilai3 = new string[255];
            nilai4 = new string[255];

            for (int i = 1; i <= c; i++)
            {


                Console.Write("\n\tNIS Siswa = ", i + 1);
                id[i] = Console.ReadLine();
                Console.Write("\tNama Siswa = ", i + 1);
                nama[i] = Console.ReadLine();
                Console.Write("\tJurusan = ", i + 1);
                jurusan[i] = Console.ReadLine();

                Console.WriteLine("\n\tMata Pelajaran DP1");
                Console.Write("\tNilai = ", i + 1);
                nilai[i] = Console.ReadLine();
                Console.WriteLine("\tKKM = 75");

                Console.WriteLine("\n\tMata Pelajaran DP2");
                Console.Write("\tNilai = ", i + 1);
                nilai1[i] = Console.ReadLine();
                Console.WriteLine("\tKKM = 75");

                Console.WriteLine("\n\tMata Pelajaran DP3");
                Console.Write("\tNilai = ", i + 1);
                nilai2[i] = Console.ReadLine();
                Console.WriteLine("\tKKM = 75");

                Console.WriteLine("\n\tMata Pelajaran DP4");
                Console.Write("\tNilai = ", i + 1);
                nilai3[i] = Console.ReadLine();
                Console.WriteLine("\tKKM = 75");

                Console.WriteLine("\n\tMata Pelajaran SKD");
                Console.Write("\tNilai = ", i + 1);
                nilai4[i] = Console.ReadLine();
                Console.WriteLine("\tKKM = 75");
            }
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public void Tampil()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            for (int j = 1; j <= c; j++)
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("\n\n\tNIS Siswa = {1}", j + 1, id[j]);
                Console.Write("\n\tNama Siswa = {1}", j + 1, nama[j]);
                Console.Write("\n\tJurusan = {1}", j + 1, jurusan[j]);
                Console.Write("\n\n\tMata Pelajaran DP1");
                Console.Write("\n\tNilai = {1}", j + 1, nilai[j]);
                Console.WriteLine("\n\tKKM = 75");
                Console.Write("\n\tMata Pelajaran DP2");
                Console.Write("\n\tNilai = {1}", j + 1, nilai1[j]);
                Console.WriteLine("\n\tKKM = 75");
                Console.Write("\n\tMata Pelajaran DP3");
                Console.Write("\n\tNilai = {1}", j + 1, nilai2[j]);
                Console.WriteLine("\n\tKKM = 75");
                Console.Write("\n\tMata Pelajaran DP4");
                Console.Write("\n\tNilai = {1}", j + 1, nilai3[j]);
                Console.WriteLine("\n\tKKM = 75");
                Console.Write("\n\tMata Pelajaran SKD");
                Console.Write("\n\tNilai = {1}", j + 1, nilai4[j]);
                Console.WriteLine("\n\tKKM = 75");
            }
            Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
