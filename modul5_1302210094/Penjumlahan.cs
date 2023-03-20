using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210094
{
    internal class Penjumlahan
    {
   

        public void JumlahTigaAngka<T>(T data1, T data2, T data3){
            T jml;
            jml = (dynamic)data1 + (dynamic)data2 + (dynamic)data3;
            Console.WriteLine(" Hasil Penjumlahan " + jml);
        }

    }
}
