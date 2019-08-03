using System;

namespace Al
{
    class Kucing
    {
        private string nama, ras;
        private int umur;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Ras
        {
            get { return ras; }
            set { ras = value; }
        }

        public int Umur
        {
            get { return umur; }
            set { umur = value; }
        }
    }
}

namespace Al
{
    class Sphynx : Kucing
    {
        public Sphynx()
        {
            Nama = "Kucing Sphynx";
            Ras = "Sphynx";
            Umur = 4;
        }
    }

    class Persia : Kucing
    {
        public Persia()
        {
            Nama = "Kucing persia";
            Ras = "Persia";
            Umur = 3;
        }
    }

    class Himalaya : Kucing
    {
        public Himalaya()
        {
            Nama = "Kucing Himalaya";
            Ras = "Himalaya";
            Umur = 2;
        }
    }
}

namespace Al
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphynx sphynx = new Sphynx();
            Persia persia = new Persia();
            Himalaya himalaya = new Himalaya();

            Console.WriteLine("Nama : {0} ", sphynx.Nama);
            Console.WriteLine("Ras : {0} ", sphynx.Ras);
            Console.WriteLine("Umur : {0} Tahun", sphynx.Umur);
            Console.WriteLine();

            Console.WriteLine("Nama : {0} ", persia.Nama);
            Console.WriteLine("Ras : {0} ", persia.Ras);
            Console.WriteLine("Umur : {0} Tahun", persia.Umur);
            Console.WriteLine();

            Console.WriteLine("Nama : {0} ", himalaya.Nama);
            Console.WriteLine("Ras : {0} ", himalaya.Ras);
            Console.WriteLine("Umur : {0} Tahun", himalaya.Umur);

            Console.ReadKey();
        }
    }
}
