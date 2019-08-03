using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
	class Program
	{
		public static void Main(string[] args)
		{
			string username, password;
			Console.Clear();
			const string USERNAME = "admin";
	    		const string PASSWORD = "123";
	    	for ( ; ; )
	    	{
	        	Console.WriteLine("Masukkan username dan password");
	        	Console.Write("Username: ");
	       	 	username = Console.ReadLine();

	        	Console.Write("Password: ");
	       		password = Console.ReadLine();
	        	Console.WriteLine();

	        	if((username==USERNAME)&&(password==PASSWORD))
	        	{
	           		break;
	       		}
	    	}

	    	Console.Write("\nMemuat");Thread.Sleep(1000);
	    	Console.Write(".");Thread.Sleep(1000);
	    	Console.Write(".");Thread.Sleep(1000);
	    	Console.Write(".");Thread.Sleep(2000);
	    	Console.WriteLine("\nProses Selesai ^_^");
	    	Console.WriteLine();

	    	Console.WriteLine("Selamat Datang " +username +" di Pemrograman Kasir");Thread.Sleep(2000);

			// Sambutan

			Console.WriteLine();
			Console.WriteLine("           ==================================================== ");
			Console.WriteLine();
			Console.WriteLine("                 Selamat Datang di Asfire elektronik shop ");
			Console.WriteLine();
			Console.WriteLine("           Kami Melayani Pembelian Alat Elektronik Berkualitas ");
			Console.WriteLine();
			Console.WriteLine("           ==================================================== ");

			transaksi :

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("    Menu Pilihan ");
			Console.WriteLine(" —————— ");
			Console.WriteLine(" 1. Mesin cuci Sharp top load        = Rp 2.299.000 ");
			Console.WriteLine(" 2. Mesin cuci Polytron              = Rp 3.199.000 ");
			Console.WriteLine(" 3. Hp Samsung Galaxy Mega           = Rp 4.950.000 ");
			Console.WriteLine(" 4. Hp Iphone X 64GB                 = Rp 17.000.000");
			Console.WriteLine(" 5. Ac LG inveter                    = Rp 3.650.000 ");
			Console.WriteLine(" 6. Ac LG dual cool eco              = Rp 3.499.000 ");
			Console.WriteLine(" 7. Kipas Angin cosmos 16            = Rp 159.000   ");
			Console.WriteLine(" 8. Kulkas Sharp SJM                 = Rp 1.650.000 ");
			Console.WriteLine(" 9. Kulkas Panasonic NRB269N         = Rp 3.200.000 ");
			Console.WriteLine(" 10. TV LED LG 20inch                = Rp 1.200.000 ");

			// Deklarasi Variabel

			string pilihan, ulang, seleksi;
			byte quantity = 0;
			uint MesincuciSharptopload=2299000, MesincuciPolytron=3199000, HpsamsungGalaxyMega=4950000;
			uint HpiphoneX64GB=17000000, AcLGinveter=3650000, AcLGdual=3499000, KipasAngin=159000;
			uint KulkasSharp=1650000, KulkasPanasonic=3200000, TVLED=1200000;
			uint totalHarga, tunai, kembalian = 0;
			
			pilih :
			
			Console.WriteLine();

			Console.Write(" Masukkan Angka Pilihan : ");
			pilihan = Convert.ToString(Console.ReadLine ());

			// 1. input Mesin Cuci Sharp

			if(pilihan == "1")
			{
				Console.WriteLine();
				Console.WriteLine("    1. Mesin cuci Sharp top load  ");
				Console.WriteLine("  ————————— ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = MesincuciSharptopload*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());
				Console.WriteLine();

				Console.Write(" Beli barang lain? (Y/N) : ");
				seleksi = Convert.ToString( Console.ReadLine ());

				if ((seleksi == "Y")||(seleksi == "y"))
				{
					goto pilih;					
				}

				else if((seleksi == "N")||(seleksi == "n"))
				{
					// 5. Input tunai

					Console.Write("          Tunai    : Rp ");
					tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

					kembalian = tunai-totalHarga;

				// 7. Output kembalian

					Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
					Console.WriteLine(" #=================#==============# ");
				}

			}

			// 1. input Mesin Cuci Polytron

			else if(pilihan == "2")
			{
				Console.WriteLine();
				Console.WriteLine("    2. Mesin cuci Polytron  ");
				Console.WriteLine("  ————————— ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = MesincuciPolytron*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());

				// 5. Input tunai

				Console.Write("          Tunai    : Rp ");
				tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

				kembalian = tunai-totalHarga;

				// 7. Output kembalian

				Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
				Console.WriteLine(" #=================#==============# ");

			}

			// 1. input Samsung Galaxy Mega

			else if(pilihan == "3")
			{
				Console.WriteLine();
				Console.WriteLine("    3. Hp Samsung Galaxy Mega  ");
				Console.WriteLine("  ———————————— ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = HpsamsungGalaxyMega*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());

				// 5. Input tunai

				Console.Write("          Tunai    : Rp ");
				tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

				kembalian = tunai-totalHarga;

				// 7. Output kembalian

				Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
				Console.WriteLine(" #=================#==============# ");

			}

			// 1. input Iphone X 64GB

			else if (pilihan == "4")
			{
				Console.WriteLine();
				Console.WriteLine("    4. Hp Iphone X 64GB  ");
				Console.WriteLine("  ———————————- ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = HpiphoneX64GB*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());

				// 5. Input tunai

				Console.Write("          Tunai    : Rp ");
				tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

				kembalian = tunai-totalHarga;

				// 7. Output kembalian

				Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
				Console.WriteLine(" #=================#==============# ");

			}

			// 1. input Ac LG inverter

			else if (pilihan == "5")
			{
				Console.WriteLine();
				Console.WriteLine("    5. Ac LG inveter  ");
				Console.WriteLine("  ——————————- ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = AcLGinveter*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());

				// 5. Input tutnai

				Console.Write("          Tunai    : Rp ");
				tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

				kembalian = tunai-totalHarga;

				// 7. Output kembalian

				Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
				Console.WriteLine(" #=================#==============# ");

			}

			else if (pilihan == "6")
			{
				Console.WriteLine();
				Console.WriteLine("    6. Ac LG dual cool eco  ");
				Console.WriteLine("  ——————————- ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = AcLGdual*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());

				// 5. Input tutnai

				Console.Write("          Tunai    : Rp ");
				tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

				kembalian = tunai-totalHarga;

				// 7. Output kembalian

				Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
				Console.WriteLine(" #=================#==============# ");

			}

			else if (pilihan == "7")
			{
				Console.WriteLine();
				Console.WriteLine("    7. Kipas Angin cosmos 16  ");
				Console.WriteLine("  ——————————- ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = KipasAngin*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());

				// 5. Input tutnai

				Console.Write("          Tunai    : Rp ");
				tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

				kembalian = tunai-totalHarga;

				// 7. Output kembalian

				Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
				Console.WriteLine(" #=================#==============# ");

			}

			else if (pilihan == "8")
			{
				Console.WriteLine();
				Console.WriteLine("    8. Kulkas Sharp SJM  ");
				Console.WriteLine("  ——————————- ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = KulkasSharp*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());

				// 5. Input tutnai

				Console.Write("          Tunai    : Rp ");
				tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

				kembalian = tunai-totalHarga;

				// 7. Output kembalian

				Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
				Console.WriteLine(" #=================#==============# ");

			}

			else if (pilihan == "9")
			{
				Console.WriteLine();
				Console.WriteLine("    9. Kulkas Panasonic NRB269N  ");
				Console.WriteLine("  ——————————- ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = KulkasPanasonic*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());

				// 5. Input tutnai

				Console.Write("          Tunai    : Rp ");
				tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

				kembalian = tunai-totalHarga;

				// 7. Output kembalian

				Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
				Console.WriteLine(" #=================#==============# ");

			}

			else if (pilihan == "10")
			{
				Console.WriteLine();
				Console.WriteLine("    10. TV LED LG 20inch  ");
				Console.WriteLine("  ——————————- ");

				// 2. input quantity

				Console.WriteLine();
				Console.Write(" Masukkan Quantity : ");
				quantity = Convert.ToByte(Console.ReadLine());

				// 3. Proses total harga

				totalHarga = TVLED*quantity;

				// 4. Output total harga

				Console.WriteLine();
				Console.WriteLine(" #=================#==============# ");
				Console.WriteLine("    Total Harga    : Rp {0}",totalHarga.ToString());

				// 5. Input tutnai

				Console.Write("          Tunai    : Rp ");
				tunai = Convert.ToUInt32(Console.ReadLine());

				// 6. Proses kembalian

				kembalian = tunai-totalHarga;

				// 7. Output kembalian

				Console.WriteLine("      Kembalian    : Rp {0}",kembalian.ToString());
				Console.WriteLine(" #=================#==============# ");

			}
			else
			{
				Console.WriteLine();
				Console.WriteLine(" Kode salah!! silahkan periksa kembali... ");
				Console.ReadKey(true);
			}

			// Mengulang transaksi

			Console.WriteLine();
			Console.Write(" Apakah anda ingin mengulang transaksi ? [y/t] : ");
			ulang = Convert.ToString(Console.ReadLine());
			if (ulang == "y" || ulang == "Y")
			goto transaksi;

			// Penutup

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(" ========================================================");
			Console.WriteLine();
			Console.WriteLine("         Terimakasi Telah Melakukan Transaksi !!! ");
			Console.WriteLine();
			Console.WriteLine("      Kami Memberikan Harga Murah Tapi Bukan Murahan ");
			Console.WriteLine();
			Console.WriteLine("            Menurut Kami Kualitas itu nomer 1 ");
			Console.WriteLine();
			Console.WriteLine("                Asfire elektronik shop ");
			Console.WriteLine();
			Console.WriteLine(" ========================================================");

			Console.WriteLine();

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			Console.Clear();
		}
	}
}
