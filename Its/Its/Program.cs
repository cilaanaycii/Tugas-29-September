using System;

namespace tugasTeknik
{
    class Home
    {
        public static void Main(string[] args)
        {
           
            string status = "Lulus";
            int kkmTka = 280;
            int kkmUtbk = 600;
            bool totalNilai = true;

            while (totalNilai)
            {

                Console.WriteLine("Ketik Angka Untuk Memilih: ");
                Console.WriteLine("1. Hitung Nilai");
                Console.WriteLine("2. Keluar");
                int pilih = Convert.ToInt32(Console.ReadLine());

                if (pilih == 1)
                {
                    Console.Clear();
                    Console.Write("Masukkan Nilai Di Bawah Ini: ");
                    Console.WriteLine("");
                    Console.Write("Nilai TKA MTK: ");
                    double nilaiMtk = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nilai TKA Bingg: ");
                    double nilaiBingg = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nilai TKA Mapel Pilihan: ");
                    double nilaiMapil = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nilai UTBK: ");
                    double nilaiUTBK = Convert.ToDouble(Console.ReadLine());


                    double totalTKA = nilaiMtk + nilaiBingg + nilaiMapil;
                    double gabTka = totalTKA * 0.30;
                    double totalUTBK = nilaiUTBK + gabTka;

                    Console.WriteLine(totalTKA);
                    Console.WriteLine(totalUTBK);

                    if (totalTKA >= kkmTka)
                    {
                        Console.WriteLine("Lulus Jalur Prestasi");
                    }

                    else
                    {
                        Console.WriteLine("Tidak Lulus Jalur Prestasi");
                    }


                    if (totalUTBK >= kkmUtbk)
                    {
                        Console.WriteLine("Anda Lulus Jalur UTBK");
                    }
                    else
                    {
                        Console.WriteLine("Anda Tidak Lulus Jalur UTBK");
                    }

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (pilih == 2) ;
                {
                    totalNilai = false;
                }
            } 
        }
    }
}
