using System;

namespace HargaBuku
{
    class Home
    {
        static void Main(string[] args)
        {

            string total = "Total Harga";

            double hargaBuku1 = 100;
            double hargaBuku2 = 200;
            double hargaBuku3 = 300;
            double hargaBulpen = 500;
            double hargaTotalBulpen = hargaBulpen * 2;

            double totalBelanja = hargaBuku1 + hargaBuku2 + hargaBuku3 + hargaTotalBulpen;

            double diskon20 = 0.20;
            double syaratDiskon = totalBelanja - hargaBuku1;


            if (totalBelanja >= 1500)
            {
                syaratDiskon = syaratDiskon - (syaratDiskon * diskon20);

            }

            Console.WriteLine(syaratDiskon);
        }
    }
}
