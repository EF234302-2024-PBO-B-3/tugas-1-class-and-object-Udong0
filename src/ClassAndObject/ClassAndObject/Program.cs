using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;


namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku1 = new Buku("Laskar Pelangi", "Andrea Hirata", 2005);
            buku1.TampilkanInfo();

            // Mobil
            Mobil mobil1 = new Mobil("Toyota", "Avanza", 2020);
            mobil1.TampilkanSpesifikasi();

            // Laptop
            Laptop laptop1 = new Laptop("Dell", "Intel i7", 16, 512);
            laptop1.TampilkanSpesifikasi();

            // Sepeda
            Sepeda sepeda1 = new Sepeda("Polygon", "Mountain Bike", 14.5);
            sepeda1.TampilkanInformasi();

            // Kalkulator
            Kalkulator kalkulator = new Kalkulator();
            double hasilTambah = kalkulator.Tambah(10, 5);
            double hasilKurang = kalkulator.Kurang(10, 5);
            double hasilKali = kalkulator.Kali(10, 5);
            double hasilBagi = kalkulator.Bagi(10, 5);

            Console.WriteLine($"Hasil Tambah: {hasilTambah}");
            Console.WriteLine($"Hasil Kurang: {hasilKurang}");
            Console.WriteLine($"Hasil Kali: {hasilKali}");
            Console.WriteLine($"Hasil Bagi: {hasilBagi}");
        }
            


        
    }
}
