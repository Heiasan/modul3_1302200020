// See https://aka.ms/new-console-template for more information
using System;

namespace modul3_1302200020
{
    class Program
    {

        static void Main(string[] args)
        {
          //  NameFruit nama = new NameFruit();
          //  nama.getNameFruit();

            PosisiKarakterGame posisiChar = new PosisiKarakterGame();


            posisiChar.activateGerak(tombol.TombolW);
            Console.WriteLine(posisiChar.currentState);

            posisiChar.activateGerak(tombol.TombolX);
            Console.WriteLine(posisiChar.currentState);

            posisiChar.activateGerak(tombol.TombolS);
            Console.WriteLine(posisiChar.currentState);

            posisiChar.activateGerak(tombol.TombolW);
            posisiChar.activateGerak(tombol.TombolW);
            Console.WriteLine(posisiChar.currentState);
        }
    }
}
