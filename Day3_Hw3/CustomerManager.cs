using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_Hw3
{
    class CustomerManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine("Tebrikler! " + musteri.ıd +
            " numaralı müşteri veri tabanına kaydedildi.");
        }
        public void Remove(Musteri musteri)
        {
            Console.WriteLine(" Tebrikler! " + musteri.ıd +
            " numaralı müşteri veri tabanından silindi.");
        }
    }
}
